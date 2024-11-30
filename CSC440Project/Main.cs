using static CSC440Project.Grade;
using static CSC440Project.Student;

using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace CSC440Project
{

    public partial class Main : Form
    {
        const string conn_string = "server=csitmariadb;user=student;database=csc340_db;password=Maroon@21?";
        public Main()
        {
            InitializeComponent();
            this.PanelAddGrade.Visible = false;
            this.PanelRecords.Visible = false;
            this.PopulateComboBox();
        }

        // --------------- Use Case 1: Import Grades ---------------
        private void ButtonImportGrades_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    Grade import_grades = new Grade(conn_string);
                    import_grades.ImportGrades(selectedPath);

                }
            }

        }
        // ---------------------------------------------------------



        // --------------- Use Case 2: Add Grade ---------------

        private void ButtonAddGrade_Click(object sender, EventArgs e)
        {
            this.PanelAddGrade.Visible = true;
            this.PanelRecords.Visible = false;
        }

        // addGrade()
        private void ButtonSubmitAddGrade_Click(object sender, EventArgs e)
        {
            

            // Get info from user input
            string student_id = TextBoxStudentID.Text;
            string grade = TextBoxStudentGrade.Text;
            string crn = TextBoxCRN.Text;

            // Input validation
            int grade_int, student_id_int, crn_int;
            bool grade_is_numerical = int.TryParse(grade, out grade_int);
            bool student_id_is_numerical = int.TryParse(student_id, out student_id_int);
            bool crn_is_numerical = int.TryParse(crn, out crn_int);


            // Insert grade
            Grade new_grade = new Grade(conn_string);
            new_grade.insertGrade(grade_int, student_id_int, crn_int);


            //MessageBox.Show("A record already exists for this Student and Class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show("The Student's record has been updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -----------------------------------------------------

        // --------------- Use Case 3+4: Util ---------------
        private void ButtonViewRecords_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn_string);

            try
            {
                mySqlConnection.Open();
                string sql = "SELECT g.crn, c.course_prefix, c.course_num, s.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, g.grade AS student_grade FROM 440_jmp_grades g JOIN 440_jmp_courses c ON g.crn = c.crn JOIN 440_jmp_students s ON g.student_id = s.student_id;";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // clear datagridview
                dataGridView1.Rows.Clear();

                while (reader.Read())
                { 
                    int crn = reader.GetInt32(0);
                    string course_prefix = reader.GetString(1);
                    int course_num = reader.GetInt32(2);
                    int student_id = reader.GetInt32(3);
                    string student_name = reader.GetString(4);
                    string student_grade = reader.GetString(5);

                    dataGridView1.Rows.Add(crn, course_prefix, course_num, student_id, student_name, student_grade, "Edit", "Delete");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            

            this.PanelAddGrade.Visible = false;
            this.PanelRecords.Visible = true;
        }

        private void ButtonViewCourseRecords_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn_string);

            try
            {
                mySqlConnection.Open();
                string sql;

                // Build the SQL query dynamically based on the inputs
                if (string.IsNullOrEmpty(TextBoxRecordsCRN.Text) &&
                    (ComboBoxViewStudent.SelectedItem == null || ComboBoxViewStudent.SelectedItem.ToString() == "All Students"))
                {
                    // No filters: fetch all records
                    sql = "SELECT g.crn, c.course_prefix, c.course_num, s.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, g.grade AS student_grade " +
                          "FROM 440_jmp_grades g " +
                          "JOIN 440_jmp_courses c ON g.crn = c.crn " +
                          "JOIN 440_jmp_students s ON g.student_id = s.student_id";
                }
                else if (!string.IsNullOrEmpty(TextBoxRecordsCRN.Text) &&
                         (ComboBoxViewStudent.SelectedItem == null || ComboBoxViewStudent.SelectedItem.ToString() == "All Students"))
                {
                    // Filter by CRN only
                    sql = "SELECT g.crn, c.course_prefix, c.course_num, s.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, g.grade AS student_grade " +
                          "FROM 440_jmp_grades g " +
                          "JOIN 440_jmp_courses c ON g.crn = c.crn " +
                          "JOIN 440_jmp_students s ON g.student_id = s.student_id " +
                          "WHERE g.crn = @crn";
                }
                else if (string.IsNullOrEmpty(TextBoxRecordsCRN.Text) &&
                         ComboBoxViewStudent.SelectedItem != null && ComboBoxViewStudent.SelectedItem.ToString() != "All Students")
                {
                    // Filter by student name only
                    sql = "SELECT g.crn, c.course_prefix, c.course_num, s.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, g.grade AS student_grade " +
                          "FROM 440_jmp_grades g " +
                          "JOIN 440_jmp_courses c ON g.crn = c.crn " +
                          "JOIN 440_jmp_students s ON g.student_id = s.student_id " +
                          "WHERE CONCAT(s.first_name, ' ', s.last_name) = @student_name";
                }
                else
                {
                    // Filter by both CRN and student name
                    sql = "SELECT g.crn, c.course_prefix, c.course_num, s.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, g.grade AS student_grade " +
                          "FROM 440_jmp_grades g " +
                          "JOIN 440_jmp_courses c ON g.crn = c.crn " +
                          "JOIN 440_jmp_students s ON g.student_id = s.student_id " +
                          "WHERE g.crn = @crn AND CONCAT(s.first_name, ' ', s.last_name) = @student_name";
                }

                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);

                // Add parameters dynamically based on the inputs
                if (!string.IsNullOrEmpty(TextBoxRecordsCRN.Text))
                {
                    cmd.Parameters.AddWithValue("@crn", TextBoxRecordsCRN.Text);
                }

                if (ComboBoxViewStudent.SelectedItem != null && ComboBoxViewStudent.SelectedItem.ToString() != "All Students")
                {
                    cmd.Parameters.AddWithValue("@student_name", ComboBoxViewStudent.SelectedItem.ToString());
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear the DataGridView
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    int crn = reader.GetInt32(0);
                    string course_prefix = reader.GetString(1);
                    int course_num = reader.GetInt32(2);
                    int student_id = reader.GetInt32(3);
                    string student_name = reader.GetString(4);
                    string student_grade = reader.GetString(5);

                    dataGridView1.Rows.Add(crn, course_prefix, course_num, student_id, student_name, student_grade, "Edit", "Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }





        // Edit and Delete buttons for records table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell
            if (e.ColumnIndex == dataGridView1.Columns["EditRow"].Index && e.RowIndex >= 0)
            {
                // Determine which row was clicked
                int rowIndex = e.RowIndex;

                string studentId = dataGridView1.Rows[rowIndex].Cells["StudentID"].Value.ToString();
                string studentName = dataGridView1.Rows[rowIndex].Cells["StudentName"].Value.ToString();
                string crn = dataGridView1.Rows[rowIndex].Cells["CRN"].Value.ToString();
                string grade = dataGridView1.Rows[rowIndex].Cells["StudentGrade"].Value.ToString();

                EditRecord editRecord = new EditRecord();
                editRecord.setValues(crn, studentId, studentName, grade);
                editRecord.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeleteRow"].Index && e.RowIndex >= 0)
            {

                DeleteRecord deleteRecord = new DeleteRecord();
                DialogResult result = deleteRecord.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int rowIndex = e.RowIndex;

                    string studentId = dataGridView1.Rows[rowIndex].Cells["StudentID"].Value.ToString();
                    string crn = dataGridView1.Rows[rowIndex].Cells["CRN"].Value.ToString();

                    Grade delete_grade = new Grade(conn_string);
                    delete_grade.deleteGrade(studentId, crn);
                }


            }

        }

        // Populate combo box with student names
        private void PopulateComboBox()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn_string);

            try
            {
                mySqlConnection.Open();

                // Query to get all students' names
                string sql = "SELECT CONCAT(first_name, ' ', last_name) AS student_name FROM 440_jmp_students;";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear the ComboBox first (to avoid duplicates on multiple calls)
                ComboBoxViewStudent.Items.Clear();

                // Add "All Students" as the default option
                ComboBoxViewStudent.Items.Add("All Students");

                // Populate ComboBox with student names from the database
                while (reader.Read())
                {
                    string studentName = reader.GetString("student_name");
                    ComboBoxViewStudent.Items.Add(studentName);
                }

                // Set the default selected value
                ComboBoxViewStudent.SelectedItem = "All Students";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                mySqlConnection.Close();
            }
        }


        // -------------------------------------------------



        // --------------- Use Case 3: Delete Grade --------------


        // --------------------------------------------------------



        // --------------- Use Case 4: Edit Grade ---------------
        // ------------------------------------------------------



        // --------------- Use Case 5: Print Transcript ---------------
        private void ButtonPrintTranscript_Click(object sender, EventArgs e)
        {
            PrintTranscript printTranscript = new PrintTranscript(conn_string);
            printTranscript.ShowDialog();
        }
        // ------------------------------------------------------------





        

        

        

       

        private void AddStudentGrade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxRecordsCRN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}