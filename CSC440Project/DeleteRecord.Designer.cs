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
            this.LabelDeleteRecord = new System.Windows.Forms.Label();
            this.LabelPressConfirm = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDeleteRecord
            // 
            this.LabelDeleteRecord.AutoSize = true;
            this.LabelDeleteRecord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelDeleteRecord.Location = new System.Drawing.Point(8, 9);
            this.LabelDeleteRecord.Name = "LabelDeleteRecord";
            this.LabelDeleteRecord.Size = new System.Drawing.Size(335, 30);
            this.LabelDeleteRecord.TabIndex = 0;
            this.LabelDeleteRecord.Text = "You are about to delete a record.";
            // 
            // LabelPressConfirm
            // 
            this.LabelPressConfirm.AutoSize = true;
            this.LabelPressConfirm.Location = new System.Drawing.Point(12, 48);
            this.LabelPressConfirm.Name = "LabelPressConfirm";
            this.LabelPressConfirm.Size = new System.Drawing.Size(188, 15);
            this.LabelPressConfirm.TabIndex = 1;
            this.LabelPressConfirm.Text = "Press confirm to delete the record.";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(187, 71);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfirm.TabIndex = 2;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(268, 71);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 107);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.LabelPressConfirm);
            this.Controls.Add(this.LabelDeleteRecord);
            this.Name = "DeleteRecord";
            this.Text = "DeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelDeleteRecord;
        private Label LabelPressConfirm;
        private Button ButtonConfirm;
        private Button ButtonCancel;
    }
}