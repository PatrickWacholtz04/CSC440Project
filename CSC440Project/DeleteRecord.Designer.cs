namespace CSC440Project
{
    partial class DeleteRecord
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
            LabelDeleteRecord = new Label();
            LabelPressConfirm = new Label();
            ButtonConfirm = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // LabelDeleteRecord
            // 
            LabelDeleteRecord.AutoSize = true;
            LabelDeleteRecord.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LabelDeleteRecord.Location = new Point(8, 9);
            LabelDeleteRecord.Name = "LabelDeleteRecord";
            LabelDeleteRecord.Size = new Size(335, 30);
            LabelDeleteRecord.TabIndex = 0;
            LabelDeleteRecord.Text = "You are about to delete a record.";
            // 
            // LabelPressConfirm
            // 
            LabelPressConfirm.AutoSize = true;
            LabelPressConfirm.Location = new Point(12, 48);
            LabelPressConfirm.Name = "LabelPressConfirm";
            LabelPressConfirm.Size = new Size(188, 15);
            LabelPressConfirm.TabIndex = 1;
            LabelPressConfirm.Text = "Press confirm to delete the record.";
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.Location = new Point(187, 71);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.Size = new Size(75, 23);
            ButtonConfirm.TabIndex = 2;
            ButtonConfirm.Text = "Confirm";
            ButtonConfirm.UseVisualStyleBackColor = true;
            ButtonConfirm.Click += ButtonConfirm_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(268, 71);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 3;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // DeleteRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 107);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonConfirm);
            Controls.Add(LabelPressConfirm);
            Controls.Add(LabelDeleteRecord);
            Name = "DeleteRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDeleteRecord;
        private Label LabelPressConfirm;
        private Button ButtonConfirm;
        private Button ButtonCancel;
    }
}