namespace CSC440Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAddGrade = new System.Windows.Forms.Button();
            this.ButtonImportGrades = new System.Windows.Forms.Button();
            this.PanelAddGrade = new System.Windows.Forms.Panel();
            this.ButtonSubmitAddGrade = new System.Windows.Forms.Button();
            this.LabelAddGrade = new System.Windows.Forms.Label();
            this.TextBoxCRN = new System.Windows.Forms.TextBox();
            this.TextBoxStudentGrade = new System.Windows.Forms.TextBox();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.LabelCRN = new System.Windows.Forms.Label();
            this.LabelStudentGrade = new System.Windows.Forms.Label();
            this.LabelStudentID = new System.Windows.Forms.Label();
            this.ButtonViewRecords = new System.Windows.Forms.Button();
            this.PanelRecords = new System.Windows.Forms.Panel();
            this.LabelViewStudentRecords = new System.Windows.Forms.Label();
            this.ComboBoxViewStudent = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonViewCourseRecords = new System.Windows.Forms.Button();
            this.TextBoxRecordsCRN = new System.Windows.Forms.TextBox();
            this.LabelRecordsCRN = new System.Windows.Forms.Label();
            this.LabelViewEditRecords = new System.Windows.Forms.Label();
            this.ButtonPrintTranscript = new System.Windows.Forms.Button();
            this.PanelAddGrade.SuspendLayout();
            this.PanelRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddGrade
            // 
            this.ButtonAddGrade.Location = new System.Drawing.Point(12, 12);
            this.ButtonAddGrade.Name = "ButtonAddGrade";
            this.ButtonAddGrade.Size = new System.Drawing.Size(121, 51);
            this.ButtonAddGrade.TabIndex = 0;
            this.ButtonAddGrade.Text = "Add Grade";
            this.ButtonAddGrade.UseVisualStyleBackColor = true;
            // 
            // ButtonImportGrades
            // 
            this.ButtonImportGrades.Location = new System.Drawing.Point(12, 69);
            this.ButtonImportGrades.Name = "ButtonImportGrades";
            this.ButtonImportGrades.Size = new System.Drawing.Size(121, 48);
            this.ButtonImportGrades.TabIndex = 1;
            this.ButtonImportGrades.Text = "Import Grades";
            this.ButtonImportGrades.UseVisualStyleBackColor = true;
            // 
            // PanelAddGrade
            // 
            this.PanelAddGrade.Controls.Add(this.ButtonSubmitAddGrade);
            this.PanelAddGrade.Controls.Add(this.LabelAddGrade);
            this.PanelAddGrade.Controls.Add(this.TextBoxCRN);
            this.PanelAddGrade.Controls.Add(this.TextBoxStudentGrade);
            this.PanelAddGrade.Controls.Add(this.TextBoxStudentID);
            this.PanelAddGrade.Controls.Add(this.LabelCRN);
            this.PanelAddGrade.Controls.Add(this.LabelStudentGrade);
            this.PanelAddGrade.Controls.Add(this.LabelStudentID);
            this.PanelAddGrade.Location = new System.Drawing.Point(173, 12);
            this.PanelAddGrade.Name = "PanelAddGrade";
            this.PanelAddGrade.Size = new System.Drawing.Size(250, 213);
            this.PanelAddGrade.TabIndex = 2;
            // 
            // ButtonSubmitAddGrade
            // 
            this.ButtonSubmitAddGrade.Location = new System.Drawing.Point(138, 165);
            this.ButtonSubmitAddGrade.Name = "ButtonSubmitAddGrade";
            this.ButtonSubmitAddGrade.Size = new System.Drawing.Size(103, 37);
            this.ButtonSubmitAddGrade.TabIndex = 13;
            this.ButtonSubmitAddGrade.Text = "Submit";
            this.ButtonSubmitAddGrade.UseVisualStyleBackColor = true;
            // 
            // LabelAddGrade
            // 
            this.LabelAddGrade.AutoSize = true;
            this.LabelAddGrade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelAddGrade.Location = new System.Drawing.Point(13, 11);
            this.LabelAddGrade.Name = "LabelAddGrade";
            this.LabelAddGrade.Size = new System.Drawing.Size(135, 30);
            this.LabelAddGrade.TabIndex = 12;
            this.LabelAddGrade.Text = "Add a Grade";
            // 
            // TextBoxCRN
            // 
            this.TextBoxCRN.Location = new System.Drawing.Point(138, 116);
            this.TextBoxCRN.Name = "TextBoxCRN";
            this.TextBoxCRN.Size = new System.Drawing.Size(103, 23);
            this.TextBoxCRN.TabIndex = 11;
            // 
            // TextBoxStudentGrade
            // 
            this.TextBoxStudentGrade.Location = new System.Drawing.Point(138, 86);
            this.TextBoxStudentGrade.Name = "TextBoxStudentGrade";
            this.TextBoxStudentGrade.Size = new System.Drawing.Size(103, 23);
            this.TextBoxStudentGrade.TabIndex = 10;
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.Location = new System.Drawing.Point(138, 57);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.Size = new System.Drawing.Size(103, 23);
            this.TextBoxStudentID.TabIndex = 7;
            // 
            // LabelCRN
            // 
            this.LabelCRN.AutoSize = true;
            this.LabelCRN.Location = new System.Drawing.Point(73, 116);
            this.LabelCRN.Name = "LabelCRN";
            this.LabelCRN.Size = new System.Drawing.Size(34, 15);
            this.LabelCRN.TabIndex = 6;
            this.LabelCRN.Text = "CRN:";
            // 
            // LabelStudentGrade
            // 
            this.LabelStudentGrade.AutoSize = true;
            this.LabelStudentGrade.Location = new System.Drawing.Point(22, 86);
            this.LabelStudentGrade.Name = "LabelStudentGrade";
            this.LabelStudentGrade.Size = new System.Drawing.Size(85, 15);
            this.LabelStudentGrade.TabIndex = 5;
            this.LabelStudentGrade.Text = "Student Grade:";
            // 
            // LabelStudentID
            // 
            this.LabelStudentID.AutoSize = true;
            this.LabelStudentID.Location = new System.Drawing.Point(42, 57);
            this.LabelStudentID.Name = "LabelStudentID";
            this.LabelStudentID.Size = new System.Drawing.Size(65, 15);
            this.LabelStudentID.TabIndex = 0;
            this.LabelStudentID.Text = "Student ID:";
            // 
            // ButtonViewRecords
            // 
            this.ButtonViewRecords.Location = new System.Drawing.Point(12, 123);
            this.ButtonViewRecords.Name = "ButtonViewRecords";
            this.ButtonViewRecords.Size = new System.Drawing.Size(121, 48);
            this.ButtonViewRecords.TabIndex = 3;
            this.ButtonViewRecords.Text = "View/Edit Records";
            this.ButtonViewRecords.UseVisualStyleBackColor = true;
            // 
            // PanelRecords
            // 
            this.PanelRecords.Controls.Add(this.LabelViewStudentRecords);
            this.PanelRecords.Controls.Add(this.ComboBoxViewStudent);
            this.PanelRecords.Controls.Add(this.dataGridView1);
            this.PanelRecords.Controls.Add(this.ButtonViewCourseRecords);
            this.PanelRecords.Controls.Add(this.TextBoxRecordsCRN);
            this.PanelRecords.Controls.Add(this.LabelRecordsCRN);
            this.PanelRecords.Controls.Add(this.LabelViewEditRecords);
            this.PanelRecords.Location = new System.Drawing.Point(173, 12);
            this.PanelRecords.Name = "PanelRecords";
            this.PanelRecords.Size = new System.Drawing.Size(665, 462);
            this.PanelRecords.TabIndex = 4;
            // 
            // LabelViewStudentRecords
            // 
            this.LabelViewStudentRecords.AutoSize = true;
            this.LabelViewStudentRecords.Location = new System.Drawing.Point(178, 57);
            this.LabelViewStudentRecords.Name = "LabelViewStudentRecords";
            this.LabelViewStudentRecords.Size = new System.Drawing.Size(51, 15);
            this.LabelViewStudentRecords.TabIndex = 19;
            this.LabelViewStudentRecords.Text = "Student:";
            // 
            // ComboBoxViewStudent
            // 
            this.ComboBoxViewStudent.FormattingEnabled = true;
            this.ComboBoxViewStudent.Items.AddRange(new object[] {
            "All Students"});
            this.ComboBoxViewStudent.Location = new System.Drawing.Point(235, 54);
            this.ComboBoxViewStudent.Name = "ComboBoxViewStudent";
            this.ComboBoxViewStudent.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxViewStudent.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CRN,
            this.CoursePrefix,
            this.CourseNumber,
            this.StudentID,
            this.StudentName,
            this.StudentGrade,
            this.EditRow,
            this.DeleteRow});
            this.dataGridView1.Location = new System.Drawing.Point(13, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 331);
            this.dataGridView1.TabIndex = 17;
            // 
            // CRN
            // 
            this.CRN.HeaderText = "CRN";
            this.CRN.Name = "CRN";
            // 
            // CoursePrefix
            // 
            this.CoursePrefix.HeaderText = "Course Prefix";
            this.CoursePrefix.Name = "CoursePrefix";
            this.CoursePrefix.Width = 50;
            // 
            // CourseNumber
            // 
            this.CourseNumber.HeaderText = "Course Number";
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Width = 50;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            // 
            // StudentGrade
            // 
            this.StudentGrade.HeaderText = "Student Grade";
            this.StudentGrade.Name = "StudentGrade";
            this.StudentGrade.Width = 50;
            // 
            // EditRow
            // 
            this.EditRow.HeaderText = "Edit Row";
            this.EditRow.Name = "EditRow";
            this.EditRow.Width = 75;
            // 
            // DeleteRow
            // 
            this.DeleteRow.HeaderText = "Delete Row";
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Width = 75;
            // 
            // ButtonViewCourseRecords
            // 
            this.ButtonViewCourseRecords.Location = new System.Drawing.Point(13, 82);
            this.ButtonViewCourseRecords.Name = "ButtonViewCourseRecords";
            this.ButtonViewCourseRecords.Size = new System.Drawing.Size(143, 23);
            this.ButtonViewCourseRecords.TabIndex = 16;
            this.ButtonViewCourseRecords.Text = "View Records";
            this.ButtonViewCourseRecords.UseVisualStyleBackColor = true;
            // 
            // TextBoxRecordsCRN
            // 
            this.TextBoxRecordsCRN.Location = new System.Drawing.Point(53, 54);
            this.TextBoxRecordsCRN.Name = "TextBoxRecordsCRN";
            this.TextBoxRecordsCRN.Size = new System.Drawing.Size(103, 23);
            this.TextBoxRecordsCRN.TabIndex = 15;
            // 
            // LabelRecordsCRN
            // 
            this.LabelRecordsCRN.AutoSize = true;
            this.LabelRecordsCRN.Location = new System.Drawing.Point(13, 57);
            this.LabelRecordsCRN.Name = "LabelRecordsCRN";
            this.LabelRecordsCRN.Size = new System.Drawing.Size(34, 15);
            this.LabelRecordsCRN.TabIndex = 14;
            this.LabelRecordsCRN.Text = "CRN:";
            // 
            // LabelViewEditRecords
            // 
            this.LabelViewEditRecords.AutoSize = true;
            this.LabelViewEditRecords.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelViewEditRecords.Location = new System.Drawing.Point(13, 11);
            this.LabelViewEditRecords.Name = "LabelViewEditRecords";
            this.LabelViewEditRecords.Size = new System.Drawing.Size(191, 30);
            this.LabelViewEditRecords.TabIndex = 13;
            this.LabelViewEditRecords.Text = "View/Edit Records";
            // 
            // ButtonPrintTranscript
            // 
            this.ButtonPrintTranscript.Location = new System.Drawing.Point(12, 177);
            this.ButtonPrintTranscript.Name = "ButtonPrintTranscript";
            this.ButtonPrintTranscript.Size = new System.Drawing.Size(121, 48);
            this.ButtonPrintTranscript.TabIndex = 5;
            this.ButtonPrintTranscript.Text = "Print Transcript";
            this.ButtonPrintTranscript.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 486);
            this.Controls.Add(this.ButtonPrintTranscript);
            this.Controls.Add(this.PanelRecords);
            this.Controls.Add(this.PanelAddGrade);
            this.Controls.Add(this.ButtonViewRecords);
            this.Controls.Add(this.ButtonImportGrades);
            this.Controls.Add(this.ButtonAddGrade);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelAddGrade.ResumeLayout(false);
            this.PanelAddGrade.PerformLayout();
            this.PanelRecords.ResumeLayout(false);
            this.PanelRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonAddGrade;
        private Button ButtonImportGrades;
        private Panel PanelAddGrade;
        private Label LabelStudentID;
        private Label LabelCRN;
        private Label LabelStudentGrade;
        private TextBox TextBoxCRN;
        private TextBox TextBoxStudentGrade;
        private TextBox TextBoxStudentID;
        private Label LabelAddGrade;
        private Button ButtonSubmitAddGrade;
        private Button ButtonViewRecords;
        private Panel PanelRecords;
        private Label LabelViewEditRecords;
        private TextBox TextBoxRecordsCRN;
        private Label LabelRecordsCRN;
        private DataGridView dataGridView1;
        private Button ButtonViewCourseRecords;
        private DataGridViewTextBoxColumn CRN;
        private DataGridViewTextBoxColumn CoursePrefix;
        private DataGridViewTextBoxColumn CourseNumber;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentGrade;
        private DataGridViewButtonColumn EditRow;
        private DataGridViewButtonColumn DeleteRow;
        private Button ButtonPrintTranscript;
        private Label LabelViewStudentRecords;
        private ComboBox ComboBoxViewStudent;
    }
}