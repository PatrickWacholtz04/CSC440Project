using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CSC440Project
{
    public partial class PrintTranscript : Form
    {
        string conn_string;
        public PrintTranscript(string conn_string)
        {
            this.conn_string = conn_string;
            InitializeComponent();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            string student_id = TextBoxStudentID.Text;

            int student_id_int;

            if (!int.TryParse(student_id, out student_id_int))
            {
                MessageBox.Show("Student ID Must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Student print_transcript = new Student(conn_string);
            print_transcript.PrintTranscript(student_id_int);
        }
    }
}
