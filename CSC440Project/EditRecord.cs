using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC440Project
{
    public partial class EditRecord : Form
    {
        public EditRecord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setValues(string crn, string studentId, string studentName, string grade)
        {
            LabelCRNValue.Text = crn;
            LabelStudentIDValue.Text = studentId;
            LabelStudentNameValue.Text = studentName;
            TextBoxStudentGrade.Text = grade;
        }

        public void ButtonSubmit_Click(object sender, EventArgs e)
        {
            const string conn_string = "server=csitmariadb;user=student;database=csc340_db;password=Maroon@21?";
            // Get grade id from grade info
            string query = "SELECT grade_id FROM 440_jmp_grades WHERE crn = @crn AND student_id = @student_id";
            using (MySqlConnection conn = new MySqlConnection(conn_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@crn", LabelCRNValue.Text);
                cmd.Parameters.AddWithValue("@student_id", LabelStudentIDValue.Text );

                var result = cmd.ExecuteScalar();
                int grade_id = result != null ? Convert.ToInt32(result) : 0;
                string new_grade = TextBoxStudentGrade.Text;

                Grade edit_grade = new Grade(conn_string);
                edit_grade.editGrade(grade_id, new_grade);
            }

            this.Close();

            //MessageBox.Show($"A record already exists for {student} in course {course}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MessageBox.Show("The students' records have been updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
