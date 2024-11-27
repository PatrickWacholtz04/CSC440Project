using OfficeOpenXml;
using System.Data;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

class ImportExport {
    

    static double CalculateGPA(DataTable transcriptData) {
        double totalHours = 0.0;
        double qualityPoints = 0.0;

        foreach(DataRow row in transcriptData.Rows) {
            totalHours += Convert.ToDouble(row["hours"]);

            if (row["grade"].ToString() == "A") {
                qualityPoints += 4 * Convert.ToDouble(row["hours"]);
            } else if (row["grade"].ToString() == "B") {
                qualityPoints += 3 * Convert.ToDouble(row["hours"]);
            } else if (row["grade"].ToString() == "C") {
                qualityPoints += 2 * Convert.ToDouble(row["hours"]);
            } else if (row["grade"].ToString() == "D") {
                qualityPoints += 1 * Convert.ToDouble(row["hours"]);
            }
        }

        return qualityPoints/totalHours;
    }

    static void PrintTranscript(int studentId, string connString) {
        string filePath = "Transcript.pdf"; // Output file path

        // Create the document
        Document pdfDoc = new Document(PageSize.A4, 50, 50, 25, 25);

        try {
            // Create a writer to write to the file
            PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
            pdfDoc.Open();
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);

            // get students information from db
            try {                
                using var conn = new MySqlConnection(connString);
                conn.Open();

                string studInfoSql = "SELECT first_name, last_name FROM students WHERE student_id=@student_id";
                MySqlCommand studInfoCmd = new(studInfoSql, conn);
                studInfoCmd.Parameters.AddWithValue("@student_id", studentId);

                using MySqlDataReader myReader = studInfoCmd.ExecuteReader();
                

                // if student id exists, create transcript
                if (myReader.Read()) {
                    string firstName = myReader["first_name"]?.ToString() ?? string.Empty;
                    string lastName = myReader["last_name"]?.ToString() ?? string.Empty;

                    // Add a title
                    pdfDoc.Add(new Paragraph("Student Transcript", titleFont));
                    pdfDoc.Add(new Paragraph("\n")); // Add space

                    // Add student information
                    pdfDoc.Add(new Paragraph($"Name: {firstName} {lastName}", normalFont));
                    pdfDoc.Add(new Paragraph($"Student ID: {studentId}", normalFont));

                }
                myReader.Close();
                
                string transcriptSql = "SELECT course_prefix, course_num, semester, year, hours, grade FROM courses INNER JOIN grades on courses.crn = grades.crn WHERE grades.student_id=@student_id";
                MySqlCommand transcriptCmd = new(transcriptSql, conn);

                transcriptCmd.Parameters.AddWithValue("@student_id", studentId);

                DataTable transcriptData = new DataTable();

                using MySqlDataAdapter transcriptAdapter = new MySqlDataAdapter(transcriptCmd);
                transcriptAdapter.Fill(transcriptData);

                // calculate GPA
                string gpa = CalculateGPA(transcriptData).ToString("F2"); // format gpa to 2 decimals
                pdfDoc.Add(new Paragraph($"GPA: {gpa}", normalFont));
                pdfDoc.Add(new Paragraph("\n"));

                // Add table for grades
                PdfPTable table = new PdfPTable(6); // 6 columns
                table.WidthPercentage = 100;

                // Add table header
                table.AddCell(new PdfPCell(new Phrase("Course Prefix", titleFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Course Number", titleFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Semester", titleFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Year", titleFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Hours", titleFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Grade", titleFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                
                foreach(DataRow row in transcriptData.Rows) {
                    table.AddCell(row["course_prefix"].ToString());
                    table.AddCell(row["course_num"].ToString());
                    table.AddCell(row["semester"].ToString());
                    table.AddCell(row["year"].ToString());
                    table.AddCell(row["hours"].ToString());
                    table.AddCell(row["grade"].ToString());
                }

                // Add the table to the document
                pdfDoc.Add(table);
                conn.Close();
            } catch (Exception dbEx) {
                //
                Console.WriteLine($"Database Connection error: {dbEx.Message}");
            }
            // Add footer
            pdfDoc.Add(new Paragraph("\n"));
            pdfDoc.Add(new Paragraph("Generated on: " + System.DateTime.Now.ToString("MM/dd/yyyy"), normalFont));
        } catch (Exception ex) {
            Console.WriteLine("Error: " + ex.Message);
        } finally {
            // Close the document
            pdfDoc.Close();
        }
        Console.WriteLine("Transcript PDF created at: " + filePath);
    }

    //static void Main(string[] args) {
    //    // Connection string
    //    string connString = "Server=192.168.1.109;Database=gradeDB;User Id=mitch;Password=9Ffj0PrB4VW312q6;";

    //    //ImportGrades(connString);

    //    PrintTranscript(901770480, connString);
    //}

}