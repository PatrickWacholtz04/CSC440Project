using OfficeOpenXml;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace CSC440Project
{
    internal class Grade
    {
        string conn_string;

        public Grade(string conn_string)
        {
            this.conn_string = conn_string?? string.Empty;
        }

        public void insertGrade(string grade, int student_id, int crn)
        {
            //Console.WriteLine("Adding grade to database...");
            //Console.WriteLine("Creating SQL Connection");

            // Create sql connection
            MySqlConnection conn = new MySqlConnection(this.conn_string);
            conn.Open();

            try
            {
                //Console.WriteLine("Connecting to MySQL...");

                // Check if the grade already exists for this student and class
                string checkQuery = "SELECT COUNT(*) FROM 440_jmp_grades WHERE student_id = @student_id AND crn = @crn";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@student_id", student_id);
                checkCmd.Parameters.AddWithValue("@crn", crn);

                int recordCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                // If the record exists, dont add the grade
                if (recordCount > 0)
                {
                    MessageBox.Show("A record already exists for this Student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If the record does not exist, insert a new record
                    string sqlQuery = "INSERT INTO 440_jmp_grades(crn, student_id, grade) VALUES (@crn, @student_id, @grade)";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@student_id", student_id);
                    cmd.Parameters.AddWithValue("@crn", crn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The grade has been successfully added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                MessageBox.Show("An error occurred while processing the request. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            //Console.WriteLine("Finished. Exiting `insertGrade()`");
        }

        public void ImportGrades(string parentDirectory)
        {

            string[] directories = Directory.GetDirectories(parentDirectory);

            foreach (string dirPath in directories)
            {
                // get folder name
                string folderName = Path.GetFileName(dirPath);

                // check if folder starts with "Grades"
                if (folderName.StartsWith("Grades"))
                {
                    string[] folderParts = folderName.Split(' ');

                    if (folderParts.Length == 3)
                    {
                        string year = folderParts[1];
                        string semester = folderParts[2];

                        //Console.WriteLine($"Processing folder: {folderName}");

                        // read grade files in folder
                        string[] files = Directory.GetFiles(dirPath);
                        foreach (string filePath in files)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(filePath);

                            string[] fileParts = fileName.Split(' ');

                            // check for file name of expected length
                            if (fileParts.Length == 4)
                            {
                                string coursePrefix = fileParts[0];
                                int courseNum = int.Parse(fileParts[1]);

                                using var package = new ExcelPackage(new FileInfo(filePath));

                                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                                var worksheet = package.Workbook.Worksheets[0]; // Access the first worksheet
                                int rowCount = worksheet.Dimension.Rows;

                                // create table to store data from excel file
                                DataTable importedGrades = new DataTable();
                                importedGrades.Columns.Add("Name", typeof(string));
                                importedGrades.Columns.Add("ID", typeof(int));
                                importedGrades.Columns.Add("Grade", typeof(string));

                                int crn = -1;
                                // connect to database
                                try
                                {
                                    using var conn = new MySqlConnection(this.conn_string);
                                    conn.Open();

                                    // use file/folder name to get crn
                                    try
                                    {
                                        string crnSql = "SELECT crn FROM 440_jmp_courses WHERE course_num=@course_num AND course_prefix=@course_prefix AND year=@year AND semester=@semester";
                                        MySqlCommand crnCmd = new(crnSql, conn);

                                        crnCmd.Parameters.AddWithValue("@course_num", courseNum);
                                        crnCmd.Parameters.AddWithValue("@course_prefix", coursePrefix);
                                        crnCmd.Parameters.AddWithValue("@year", year);
                                        crnCmd.Parameters.AddWithValue("@semester", semester);

                                        using MySqlDataReader myReader = crnCmd.ExecuteReader();

                                        if (myReader.Read())
                                        {
                                            crn = Convert.ToInt32(myReader["crn"]);
                                            Console.WriteLine($"Adding grades for CRN: {crn}");
                                        }
                                    }
                                    catch (Exception crnEx)
                                    {
                                        Console.WriteLine($"Failed crn query: {crnEx.Message}");
                                    }
                                    if (crn != -1) {   
                                        // loop through each row and read data
                                        for (int row = 2; row <= rowCount; row++)
                                        {
                                            string name = worksheet.Cells[row, 1].Text;
                                            int id = int.Parse(worksheet.Cells[row, 2].Text);
                                            string grade = worksheet.Cells[row, 3].Text;

                                            importedGrades.Rows.Add(name, id, grade);

                                            // confirm student exists in db
                                            try
                                            {
                                                string studSql = "SELECT * FROM 440_jmp_students WHERE student_id=@student_id";
                                                MySqlCommand studCmd = new(studSql, conn);

                                                studCmd.Parameters.AddWithValue("@student_id", id);

                                                using MySqlDataReader myReader = studCmd.ExecuteReader();

                                                // if student id exists, confirm matches name
                                                if (myReader.Read())
                                                {
                                                    string firstName = myReader["first_name"]?.ToString() ?? string.Empty;
                                                    string lastName = myReader["last_name"]?.ToString() ?? string.Empty;

                                                    // if name matches, insert grade
                                                    if (name == firstName + " " + lastName && crn != -1)
                                                    {
                                                        myReader.Close();
                                                        try
                                                        {
                                                            string insertSql = "INSERT INTO 440_jmp_grades (grade, student_id, crn) VALUES (@grade, @student_id, @crn)";
                                                            MySqlCommand insertCmd = new(insertSql, conn);

                                                            insertCmd.Parameters.AddWithValue("@grade", grade);
                                                            insertCmd.Parameters.AddWithValue("@student_id", id);
                                                            insertCmd.Parameters.AddWithValue("@crn", crn);

                                                            insertCmd.ExecuteNonQuery();
                                                            Console.WriteLine("Grade inserted for CRN: " + crn + " for student ID: " + id);
                                                            //MessageBox.Show("Insert Success!");

                                                        }
                                                        catch (Exception insertEx)
                                                        {
                                                            //Console.WriteLine($"Insert for student {id} failed: {insertEx.Message}");
                                                            //MessageBox.Show($"Insert for student {id} failed: {insertEx.Message}", $"Error while processing course {coursePrefix} {courseNum} {year} {semester}");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"Student name: {name} does not match {id} on record!");
                                                        MessageBox.Show($"Student name: {name} does not match {id} on record!", 
                                                                        $"Error while processing course {coursePrefix} {courseNum} {year} {semester}");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Student ID: {id} does not exist!");
                                                    MessageBox.Show($"Student ID: {id} does not exist!", 
                                                                    $"Error while processing course {coursePrefix} {courseNum} {year} {semester}");
                                                }

                                            }
                                            catch (Exception studEx)
                                            {
                                                Console.WriteLine($"Failed student query: {studEx.Message}");
                                                MessageBox.Show($"Failed student query: {studEx.Message}", 
                                                                $"Error while processing course {coursePrefix} {courseNum} {year} {semester}");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The course {coursePrefix} {courseNum} {year} {semester} was not found in the database!");
                                        //MessageBox.Show($"The course {coursePrefix} {courseNum} {year} {semester} was not found in the database!");
                                    }
                                    conn.Close();
                                }
                                catch (Exception dbEx)
                                {
                                    Console.WriteLine($"Database Connection error: {dbEx.Message}");
                                }

                            }
                            else
                            {
                                Console.WriteLine($"Skipping file with unexpected format: {fileName}");
                                //MessageBox.Show($"Skipping file with unexpected format: {fileName}", $"Error while processing directory {folderName}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Skipping folder with unexpected format: {folderName}");
                        //MessageBox.Show($"Skipping folder with unexpected format: {folderName}");
                    }
                }
                else
                {
                    Console.WriteLine($"Skipping unrelated folder: {folderName}");
                    //MessageBox.Show($"Skipping unrelated folder: {folderName}");
                }
            }

            MessageBox.Show("Confirmation: Finished adding new grades", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void editGrade(int gradeId, string newGrade)
        {
            string query = "UPDATE 440_jmp_grades SET grade = @new_grade WHERE grade_id = @grade_id";

            using (MySqlConnection conn = new MySqlConnection(this.conn_string))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@new_grade", newGrade);
                    cmd.Parameters.AddWithValue("@grade_id", gradeId);

                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any row was updated
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Grade updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No records were updated. Please check the grade_id.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("error:, " + ex.Message);
                }
            }
        }

        public void deleteGrade(string studentId, string crn)
        {
            // Get grade id from grade info
            string query = "SELECT grade_id FROM 440_jmp_grades WHERE crn = @crn AND student_id = @student_id";
            using (MySqlConnection conn = new MySqlConnection(conn_string))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@crn", crn);
                    cmd.Parameters.AddWithValue("@student_id", studentId);

                    var result = cmd.ExecuteScalar();
                    int grade_id = result != null ? Convert.ToInt32(result) : 0;

                    // Use the grade id to delete the entry

                    // SQL query to delete the record where grade_id matches
                    string sqlQuery = "DELETE FROM 440_jmp_grades WHERE grade_id = @gradeId";

                    // Create command and add parameters to prevent SQL injection
                    MySqlCommand cmd_delete = new MySqlCommand(sqlQuery, conn);
                    cmd_delete.Parameters.AddWithValue("@gradeId", grade_id);

                    // Execute the query
                    int rowsAffected = cmd_delete.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The grade record has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    MessageBox.Show("An error occurred while processing the request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }

    
}
