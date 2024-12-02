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
            ButtonAddGrade = new Button();
            ButtonImportGrades = new Button();
            PanelAddGrade = new Panel();
            ButtonSubmitAddGrade = new Button();
            LabelAddGrade = new Label();
            TextBoxCRN = new TextBox();
            TextBoxStudentGrade = new TextBox();
            TextBoxStudentID = new TextBox();
            LabelCRN = new Label();
            LabelStudentGrade = new Label();
            LabelStudentID = new Label();
            ButtonViewRecords = new Button();
            PanelRecords = new Panel();
            LabelViewStudentRecords = new Label();
            ComboBoxViewStudent = new ComboBox();
            dataGridView1 = new DataGridView();
            CRN = new DataGridViewTextBoxColumn();
            CoursePrefix = new DataGridViewTextBoxColumn();
            CourseNumber = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            StudentGrade = new DataGridViewTextBoxColumn();
            EditRow = new DataGridViewButtonColumn();
            DeleteRow = new DataGridViewButtonColumn();
            ButtonViewCourseRecords = new Button();
            TextBoxRecordsCRN = new TextBox();
            LabelRecordsCRN = new Label();
            LabelViewEditRecords = new Label();
            ButtonPrintTranscript = new Button();
            PanelAddGrade.SuspendLayout();
            PanelRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonAddGrade
            // 
            ButtonAddGrade.Location = new Point(12, 12);
            ButtonAddGrade.Name = "ButtonAddGrade";
            ButtonAddGrade.Size = new Size(121, 51);
            ButtonAddGrade.TabIndex = 0;
            ButtonAddGrade.Text = "Add Grade";
            ButtonAddGrade.UseVisualStyleBackColor = true;
            ButtonAddGrade.Click += ButtonAddGrade_Click;
            // 
            // ButtonImportGrades
            // 
            ButtonImportGrades.Location = new Point(12, 69);
            ButtonImportGrades.Name = "ButtonImportGrades";
            ButtonImportGrades.Size = new Size(121, 48);
            ButtonImportGrades.TabIndex = 1;
            ButtonImportGrades.Text = "Import Grades";
            ButtonImportGrades.UseVisualStyleBackColor = true;
            ButtonImportGrades.Click += ButtonImportGrades_Click;
            // 
            // PanelAddGrade
            // 
            PanelAddGrade.Controls.Add(ButtonSubmitAddGrade);
            PanelAddGrade.Controls.Add(LabelAddGrade);
            PanelAddGrade.Controls.Add(TextBoxCRN);
            PanelAddGrade.Controls.Add(TextBoxStudentGrade);
            PanelAddGrade.Controls.Add(TextBoxStudentID);
            PanelAddGrade.Controls.Add(LabelCRN);
            PanelAddGrade.Controls.Add(LabelStudentGrade);
            PanelAddGrade.Controls.Add(LabelStudentID);
            PanelAddGrade.Location = new Point(173, 12);
            PanelAddGrade.Name = "PanelAddGrade";
            PanelAddGrade.Size = new Size(250, 213);
            PanelAddGrade.TabIndex = 2;
            // 
            // ButtonSubmitAddGrade
            // 
            ButtonSubmitAddGrade.Location = new Point(138, 165);
            ButtonSubmitAddGrade.Name = "ButtonSubmitAddGrade";
            ButtonSubmitAddGrade.Size = new Size(103, 37);
            ButtonSubmitAddGrade.TabIndex = 13;
            ButtonSubmitAddGrade.Text = "Submit";
            ButtonSubmitAddGrade.UseVisualStyleBackColor = true;
            ButtonSubmitAddGrade.Click += ButtonSubmitAddGrade_Click;
            // 
            // LabelAddGrade
            // 
            LabelAddGrade.AutoSize = true;
            LabelAddGrade.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LabelAddGrade.Location = new Point(13, 11);
            LabelAddGrade.Name = "LabelAddGrade";
            LabelAddGrade.Size = new Size(135, 30);
            LabelAddGrade.TabIndex = 12;
            LabelAddGrade.Text = "Add a Grade";
            // 
            // TextBoxCRN
            // 
            TextBoxCRN.Location = new Point(138, 116);
            TextBoxCRN.Name = "TextBoxCRN";
            TextBoxCRN.Size = new Size(103, 23);
            TextBoxCRN.TabIndex = 11;
            // 
            // TextBoxStudentGrade
            // 
            TextBoxStudentGrade.Location = new Point(138, 86);
            TextBoxStudentGrade.Name = "TextBoxStudentGrade";
            TextBoxStudentGrade.Size = new Size(103, 23);
            TextBoxStudentGrade.TabIndex = 10;
            // 
            // TextBoxStudentID
            // 
            TextBoxStudentID.Location = new Point(138, 57);
            TextBoxStudentID.Name = "TextBoxStudentID";
            TextBoxStudentID.Size = new Size(103, 23);
            TextBoxStudentID.TabIndex = 7;
            // 
            // LabelCRN
            // 
            LabelCRN.AutoSize = true;
            LabelCRN.Location = new Point(73, 116);
            LabelCRN.Name = "LabelCRN";
            LabelCRN.Size = new Size(34, 15);
            LabelCRN.TabIndex = 6;
            LabelCRN.Text = "CRN:";
            // 
            // LabelStudentGrade
            // 
            LabelStudentGrade.AutoSize = true;
            LabelStudentGrade.Location = new Point(22, 86);
            LabelStudentGrade.Name = "LabelStudentGrade";
            LabelStudentGrade.Size = new Size(85, 15);
            LabelStudentGrade.TabIndex = 5;
            LabelStudentGrade.Text = "Student Grade:";
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.Location = new Point(42, 57);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(65, 15);
            LabelStudentID.TabIndex = 0;
            LabelStudentID.Text = "Student ID:";
            // 
            // ButtonViewRecords
            // 
            ButtonViewRecords.Location = new Point(12, 123);
            ButtonViewRecords.Name = "ButtonViewRecords";
            ButtonViewRecords.Size = new Size(121, 48);
            ButtonViewRecords.TabIndex = 3;
            ButtonViewRecords.Text = "View/Edit Records";
            ButtonViewRecords.UseVisualStyleBackColor = true;
            ButtonViewRecords.Click += ButtonViewRecords_Click;
            // 
            // PanelRecords
            // 
            PanelRecords.Controls.Add(LabelViewStudentRecords);
            PanelRecords.Controls.Add(ComboBoxViewStudent);
            PanelRecords.Controls.Add(dataGridView1);
            PanelRecords.Controls.Add(ButtonViewCourseRecords);
            PanelRecords.Controls.Add(TextBoxRecordsCRN);
            PanelRecords.Controls.Add(LabelRecordsCRN);
            PanelRecords.Controls.Add(LabelViewEditRecords);
            PanelRecords.Location = new Point(173, 12);
            PanelRecords.Name = "PanelRecords";
            PanelRecords.Size = new Size(665, 462);
            PanelRecords.TabIndex = 4;
            // 
            // LabelViewStudentRecords
            // 
            LabelViewStudentRecords.AutoSize = true;
            LabelViewStudentRecords.Location = new Point(178, 57);
            LabelViewStudentRecords.Name = "LabelViewStudentRecords";
            LabelViewStudentRecords.Size = new Size(51, 15);
            LabelViewStudentRecords.TabIndex = 19;
            LabelViewStudentRecords.Text = "Student:";
            LabelViewStudentRecords.Click += label1_Click;
            // 
            // ComboBoxViewStudent
            // 
            ComboBoxViewStudent.FormattingEnabled = true;
            ComboBoxViewStudent.Items.AddRange(new object[] { "All Students" });
            ComboBoxViewStudent.Location = new Point(235, 54);
            ComboBoxViewStudent.Name = "ComboBoxViewStudent";
            ComboBoxViewStudent.Size = new Size(121, 23);
            ComboBoxViewStudent.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CRN, CoursePrefix, CourseNumber, StudentID, StudentName, StudentGrade, EditRow, DeleteRow });
            dataGridView1.Location = new Point(13, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 331);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CRN
            // 
            CRN.HeaderText = "CRN";
            CRN.Name = "CRN";
            // 
            // CoursePrefix
            // 
            CoursePrefix.HeaderText = "Course Prefix";
            CoursePrefix.Name = "CoursePrefix";
            CoursePrefix.Width = 50;
            // 
            // CourseNumber
            // 
            CourseNumber.HeaderText = "Course Number";
            CourseNumber.Name = "CourseNumber";
            CourseNumber.Width = 50;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "Student ID";
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.Name = "StudentName";
            // 
            // StudentGrade
            // 
            StudentGrade.HeaderText = "Student Grade";
            StudentGrade.Name = "StudentGrade";
            StudentGrade.Width = 50;
            // 
            // EditRow
            // 
            EditRow.HeaderText = "Edit Row";
            EditRow.Name = "EditRow";
            EditRow.Width = 75;
            // 
            // DeleteRow
            // 
            DeleteRow.HeaderText = "Delete Row";
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Width = 75;
            // 
            // ButtonViewCourseRecords
            // 
            ButtonViewCourseRecords.Location = new Point(13, 82);
            ButtonViewCourseRecords.Name = "ButtonViewCourseRecords";
            ButtonViewCourseRecords.Size = new Size(143, 23);
            ButtonViewCourseRecords.TabIndex = 16;
            ButtonViewCourseRecords.Text = "View Records";
            ButtonViewCourseRecords.UseVisualStyleBackColor = true;
            ButtonViewCourseRecords.Click += ButtonViewCourseRecords_Click;
            // 
            // TextBoxRecordsCRN
            // 
            TextBoxRecordsCRN.Location = new Point(53, 54);
            TextBoxRecordsCRN.Name = "TextBoxRecordsCRN";
            TextBoxRecordsCRN.Size = new Size(103, 23);
            TextBoxRecordsCRN.TabIndex = 15;
            TextBoxRecordsCRN.TextChanged += TextBoxRecordsCRN_TextChanged;
            // 
            // LabelRecordsCRN
            // 
            LabelRecordsCRN.AutoSize = true;
            LabelRecordsCRN.Location = new Point(13, 57);
            LabelRecordsCRN.Name = "LabelRecordsCRN";
            LabelRecordsCRN.Size = new Size(34, 15);
            LabelRecordsCRN.TabIndex = 14;
            LabelRecordsCRN.Text = "CRN:";
            // 
            // LabelViewEditRecords
            // 
            LabelViewEditRecords.AutoSize = true;
            LabelViewEditRecords.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LabelViewEditRecords.Location = new Point(13, 11);
            LabelViewEditRecords.Name = "LabelViewEditRecords";
            LabelViewEditRecords.Size = new Size(191, 30);
            LabelViewEditRecords.TabIndex = 13;
            LabelViewEditRecords.Text = "View/Edit Records";
            // 
            // ButtonPrintTranscript
            // 
            ButtonPrintTranscript.Location = new Point(12, 177);
            ButtonPrintTranscript.Name = "ButtonPrintTranscript";
            ButtonPrintTranscript.Size = new Size(121, 48);
            ButtonPrintTranscript.TabIndex = 5;
            ButtonPrintTranscript.Text = "Print Transcript";
            ButtonPrintTranscript.UseVisualStyleBackColor = true;
            ButtonPrintTranscript.Click += ButtonPrintTranscript_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 486);
            Controls.Add(ButtonPrintTranscript);
            Controls.Add(PanelRecords);
            Controls.Add(PanelAddGrade);
            Controls.Add(ButtonViewRecords);
            Controls.Add(ButtonImportGrades);
            Controls.Add(ButtonAddGrade);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelAddGrade.ResumeLayout(false);
            PanelAddGrade.PerformLayout();
            PanelRecords.ResumeLayout(false);
            PanelRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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