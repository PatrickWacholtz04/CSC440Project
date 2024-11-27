namespace CSC440Project
{
    partial class EditRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelEditRecord = new System.Windows.Forms.Label();
            this.LabelCRN = new System.Windows.Forms.Label();
            this.LabelStudentID = new System.Windows.Forms.Label();
            this.LabelStudentGrade = new System.Windows.Forms.Label();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.TextBoxStudentGrade = new System.Windows.Forms.TextBox();
            this.LabelCRNValue = new System.Windows.Forms.Label();
            this.LabelStudentIDValue = new System.Windows.Forms.Label();
            this.LabelStudentNameValue = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelEditRecord
            // 
            this.LabelEditRecord.AutoSize = true;
            this.LabelEditRecord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelEditRecord.Location = new System.Drawing.Point(10, 12);
            this.LabelEditRecord.Name = "LabelEditRecord";
            this.LabelEditRecord.Size = new System.Drawing.Size(125, 30);
            this.LabelEditRecord.TabIndex = 0;
            this.LabelEditRecord.Text = "Edit Record";
            this.LabelEditRecord.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelCRN
            // 
            this.LabelCRN.AutoSize = true;
            this.LabelCRN.Location = new System.Drawing.Point(12, 62);
            this.LabelCRN.Name = "LabelCRN";
            this.LabelCRN.Size = new System.Drawing.Size(34, 15);
            this.LabelCRN.TabIndex = 1;
            this.LabelCRN.Text = "CRN:";
            // 
            // LabelStudentID
            // 
            this.LabelStudentID.AutoSize = true;
            this.LabelStudentID.Location = new System.Drawing.Point(12, 88);
            this.LabelStudentID.Name = "LabelStudentID";
            this.LabelStudentID.Size = new System.Drawing.Size(65, 15);
            this.LabelStudentID.TabIndex = 10;
            this.LabelStudentID.Text = "Student ID:";
            this.LabelStudentID.Click += new System.EventHandler(this.label4_Click);
            // 
            // LabelStudentGrade
            // 
            this.LabelStudentGrade.AutoSize = true;
            this.LabelStudentGrade.Location = new System.Drawing.Point(12, 146);
            this.LabelStudentGrade.Name = "LabelStudentGrade";
            this.LabelStudentGrade.Size = new System.Drawing.Size(85, 15);
            this.LabelStudentGrade.TabIndex = 11;
            this.LabelStudentGrade.Text = "Student Grade:";
            // 
            // LabelStudentName
            // 
            this.LabelStudentName.AutoSize = true;
            this.LabelStudentName.Location = new System.Drawing.Point(12, 117);
            this.LabelStudentName.Name = "LabelStudentName";
            this.LabelStudentName.Size = new System.Drawing.Size(86, 15);
            this.LabelStudentName.TabIndex = 12;
            this.LabelStudentName.Text = "Student Name:";
            // 
            // TextBoxStudentGrade
            // 
            this.TextBoxStudentGrade.Location = new System.Drawing.Point(125, 146);
            this.TextBoxStudentGrade.Name = "TextBoxStudentGrade";
            this.TextBoxStudentGrade.Size = new System.Drawing.Size(100, 23);
            this.TextBoxStudentGrade.TabIndex = 13;
            this.TextBoxStudentGrade.Text = "student_grade";
            // 
            // LabelCRNValue
            // 
            this.LabelCRNValue.AutoSize = true;
            this.LabelCRNValue.Location = new System.Drawing.Point(125, 62);
            this.LabelCRNValue.Name = "LabelCRNValue";
            this.LabelCRNValue.Size = new System.Drawing.Size(24, 15);
            this.LabelCRNValue.TabIndex = 14;
            this.LabelCRNValue.Text = "crn";
            // 
            // LabelStudentIDValue
            // 
            this.LabelStudentIDValue.AutoSize = true;
            this.LabelStudentIDValue.Location = new System.Drawing.Point(125, 88);
            this.LabelStudentIDValue.Name = "LabelStudentIDValue";
            this.LabelStudentIDValue.Size = new System.Drawing.Size(62, 15);
            this.LabelStudentIDValue.TabIndex = 17;
            this.LabelStudentIDValue.Text = "student_id";
            // 
            // LabelStudentNameValue
            // 
            this.LabelStudentNameValue.AutoSize = true;
            this.LabelStudentNameValue.Location = new System.Drawing.Point(125, 117);
            this.LabelStudentNameValue.Name = "LabelStudentNameValue";
            this.LabelStudentNameValue.Size = new System.Drawing.Size(82, 15);
            this.LabelStudentNameValue.TabIndex = 18;
            this.LabelStudentNameValue.Text = "student_name";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(12, 184);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(213, 29);
            this.ButtonSubmit.TabIndex = 19;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // EditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 225);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelStudentNameValue);
            this.Controls.Add(this.LabelStudentIDValue);
            this.Controls.Add(this.LabelCRNValue);
            this.Controls.Add(this.TextBoxStudentGrade);
            this.Controls.Add(this.LabelStudentName);
            this.Controls.Add(this.LabelStudentGrade);
            this.Controls.Add(this.LabelStudentID);
            this.Controls.Add(this.LabelCRN);
            this.Controls.Add(this.LabelEditRecord);
            this.Name = "EditRecord";
            this.Text = "EditRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelEditRecord;
        private Label LabelCRN;
        private Label LabelStudentID;
        private Label LabelStudentGrade;
        private Label LabelStudentName;
        private TextBox TextBoxStudentGrade;
        private Label LabelCRNValue;
        private Label LabelStudentIDValue;
        private Label LabelStudentNameValue;
        private Button ButtonSubmit;


        

    }
}