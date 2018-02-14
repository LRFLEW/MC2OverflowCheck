namespace MC2OverflowCheck
{
    partial class UserForm
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
            this.cmdChooseZip = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.OpenZip = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdChooseZip
            // 
            this.cmdChooseZip.Location = new System.Drawing.Point(12, 12);
            this.cmdChooseZip.Name = "cmdChooseZip";
            this.cmdChooseZip.Size = new System.Drawing.Size(75, 23);
            this.cmdChooseZip.TabIndex = 0;
            this.cmdChooseZip.Text = "Choose Zip";
            this.cmdChooseZip.UseVisualStyleBackColor = true;
            this.cmdChooseZip.Click += new System.EventHandler(this.cmdChooseZip_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 38);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(84, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "No Zip Selected";
            // 
            // OpenZip
            // 
            this.OpenZip.FileName = "OpenZipDialog";
            this.OpenZip.Filter = "Zip File|*.zip|Assets File|*.dat";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(187, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Please select an Assets zip to Analyze";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 298);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cmdChooseZip);
            this.Name = "UserForm";
            this.Text = "Midnight Club 2 Zip Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdChooseZip;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog OpenZip;
        private System.Windows.Forms.Label lblMessage;
    }
}