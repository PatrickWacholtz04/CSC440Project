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
        public PrintTranscript()
        {
            InitializeComponent();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            string conn_string = "server=localhost;user=root;database=gradeDB";
            string student_id = TextBoxStudentID.Text;

            int student_id_int = Convert.ToInt32(student_id);

            Student print_transcript = new Student(conn_string);
            print_transcript.PrintTranscript(student_id_int);
        }
    }
}
