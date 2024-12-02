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
            LabelEditRecord = new Label();
            LabelCRN = new Label();
            LabelStudentID = new Label();
            LabelStudentGrade = new Label();
            LabelStudentName = new Label();
            TextBoxStudentGrade = new TextBox();
            LabelCRNValue = new Label();
            LabelStudentIDValue = new Label();
            LabelStudentNameValue = new Label();
            ButtonSubmit = new Button();
            SuspendLayout();
            // 
            // LabelEditRecord
            // 
            LabelEditRecord.AutoSize = true;
            LabelEditRecord.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LabelEditRecord.Location = new Point(10, 12);
            LabelEditRecord.Name = "LabelEditRecord";
            LabelEditRecord.Size = new Size(125, 30);
            LabelEditRecord.TabIndex = 0;
            LabelEditRecord.Text = "Edit Record";
            LabelEditRecord.Click += label1_Click;
            // 
            // LabelCRN
            // 
            LabelCRN.AutoSize = true;
            LabelCRN.Location = new Point(12, 62);
            LabelCRN.Name = "LabelCRN";
            LabelCRN.Size = new Size(34, 15);
            LabelCRN.TabIndex = 1;
            LabelCRN.Text = "CRN:";
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.Location = new Point(12, 88);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(65, 15);
            LabelStudentID.TabIndex = 10;
            LabelStudentID.Text = "Student ID:";
            LabelStudentID.Click += label4_Click;
            // 
            // LabelStudentGrade
            // 
            LabelStudentGrade.AutoSize = true;
            LabelStudentGrade.Location = new Point(12, 146);
            LabelStudentGrade.Name = "LabelStudentGrade";
            LabelStudentGrade.Size = new Size(85, 15);
            LabelStudentGrade.TabIndex = 11;
            LabelStudentGrade.Text = "Student Grade:";
            // 
            // LabelStudentName
            // 
            LabelStudentName.AutoSize = true;
            LabelStudentName.Location = new Point(12, 117);
            LabelStudentName.Name = "LabelStudentName";
            LabelStudentName.Size = new Size(86, 15);
            LabelStudentName.TabIndex = 12;
            LabelStudentName.Text = "Student Name:";
            // 
            // TextBoxStudentGrade
            // 
            TextBoxStudentGrade.Location = new Point(125, 146);
            TextBoxStudentGrade.Name = "TextBoxStudentGrade";
            TextBoxStudentGrade.Size = new Size(100, 23);
            TextBoxStudentGrade.TabIndex = 13;
            TextBoxStudentGrade.Text = "student_grade";
            // 
            // LabelCRNValue
            // 
            LabelCRNValue.AutoSize = true;
            LabelCRNValue.Location = new Point(125, 62);
            LabelCRNValue.Name = "LabelCRNValue";
            LabelCRNValue.Size = new Size(24, 15);
            LabelCRNValue.TabIndex = 14;
            LabelCRNValue.Text = "crn";
            // 
            // LabelStudentIDValue
            // 
            LabelStudentIDValue.AutoSize = true;
            LabelStudentIDValue.Location = new Point(125, 88);
            LabelStudentIDValue.Name = "LabelStudentIDValue";
            LabelStudentIDValue.Size = new Size(62, 15);
            LabelStudentIDValue.TabIndex = 17;
            LabelStudentIDValue.Text = "student_id";
            // 
            // LabelStudentNameValue
            // 
            LabelStudentNameValue.AutoSize = true;
            LabelStudentNameValue.Location = new Point(125, 117);
            LabelStudentNameValue.Name = "LabelStudentNameValue";
            LabelStudentNameValue.Size = new Size(82, 15);
            LabelStudentNameValue.TabIndex = 18;
            LabelStudentNameValue.Text = "student_name";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(12, 184);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(213, 29);
            ButtonSubmit.TabIndex = 19;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // EditRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 225);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelStudentNameValue);
            Controls.Add(LabelStudentIDValue);
            Controls.Add(LabelCRNValue);
            Controls.Add(TextBoxStudentGrade);
            Controls.Add(LabelStudentName);
            Controls.Add(LabelStudentGrade);
            Controls.Add(LabelStudentID);
            Controls.Add(LabelCRN);
            Controls.Add(LabelEditRecord);
            Name = "EditRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditRecord";
            ResumeLayout(false);
            PerformLayout();
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