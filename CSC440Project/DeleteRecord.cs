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
    public partial class DeleteRecord : Form
    {
        Boolean DoDeleteRecord;

        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.DoDeleteRecord = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
            //MessageBox.Show("The student record has been deleted.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DoDeleteRecord = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
