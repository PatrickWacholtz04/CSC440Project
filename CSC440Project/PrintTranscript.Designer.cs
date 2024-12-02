namespace CSC440Project
{
    partial class PrintTranscript
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
            LabelPrintTranscript = new Label();
            LabelStudentID = new Label();
            TextBoxStudentID = new TextBox();
            ButtonPrint = new Button();
            SuspendLayout();
            // 
            // LabelPrintTranscript
            // 
            LabelPrintTranscript.AutoSize = true;
            LabelPrintTranscript.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LabelPrintTranscript.Location = new Point(12, 9);
            LabelPrintTranscript.Name = "LabelPrintTranscript";
            LabelPrintTranscript.Size = new Size(246, 30);
            LabelPrintTranscript.TabIndex = 0;
            LabelPrintTranscript.Text = "Print Student Transcript";
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.Location = new Point(87, 59);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(65, 15);
            LabelStudentID.TabIndex = 1;
            LabelStudentID.Text = "Student ID:";
            // 
            // TextBoxStudentID
            // 
            TextBoxStudentID.Location = new Point(158, 56);
            TextBoxStudentID.Name = "TextBoxStudentID";
            TextBoxStudentID.Size = new Size(100, 23);
            TextBoxStudentID.TabIndex = 2;
            TextBoxStudentID.Text = "student_id";
            // 
            // ButtonPrint
            // 
            ButtonPrint.Location = new Point(87, 97);
            ButtonPrint.Name = "ButtonPrint";
            ButtonPrint.Size = new Size(171, 23);
            ButtonPrint.TabIndex = 3;
            ButtonPrint.Text = "Print";
            ButtonPrint.UseVisualStyleBackColor = true;
            ButtonPrint.Click += ButtonPrint_Click;
            // 
            // PrintTranscript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 136);
            Controls.Add(ButtonPrint);
            Controls.Add(TextBoxStudentID);
            Controls.Add(LabelStudentID);
            Controls.Add(LabelPrintTranscript);
            Name = "PrintTranscript";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PrintTranscript";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPrintTranscript;
        private Label LabelStudentID;
        private TextBox TextBoxStudentID;
        private Button ButtonPrint;
    }
}