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
            this.LabelPrintTranscript = new System.Windows.Forms.Label();
            this.LabelStudentID = new System.Windows.Forms.Label();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPrintTranscript
            // 
            this.LabelPrintTranscript.AutoSize = true;
            this.LabelPrintTranscript.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelPrintTranscript.Location = new System.Drawing.Point(12, 9);
            this.LabelPrintTranscript.Name = "LabelPrintTranscript";
            this.LabelPrintTranscript.Size = new System.Drawing.Size(246, 30);
            this.LabelPrintTranscript.TabIndex = 0;
            this.LabelPrintTranscript.Text = "Print Student Transcript";
            // 
            // LabelStudentID
            // 
            this.LabelStudentID.AutoSize = true;
            this.LabelStudentID.Location = new System.Drawing.Point(87, 59);
            this.LabelStudentID.Name = "LabelStudentID";
            this.LabelStudentID.Size = new System.Drawing.Size(65, 15);
            this.LabelStudentID.TabIndex = 1;
            this.LabelStudentID.Text = "Student ID:";
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.Location = new System.Drawing.Point(158, 56);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.Size = new System.Drawing.Size(100, 23);
            this.TextBoxStudentID.TabIndex = 2;
            this.TextBoxStudentID.Text = "student_id";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(87, 97);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(171, 23);
            this.ButtonPrint.TabIndex = 3;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // PrintTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 136);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.LabelStudentID);
            this.Controls.Add(this.LabelPrintTranscript);
            this.Name = "PrintTranscript";
            this.Text = "PrintTranscript";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelPrintTranscript;
        private Label LabelStudentID;
        private TextBox TextBoxStudentID;
        private Button ButtonPrint;
    }
}