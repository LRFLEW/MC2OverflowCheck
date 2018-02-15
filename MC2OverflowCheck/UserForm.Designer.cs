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
            this.btnAboutThisExploit = new System.Windows.Forms.Button();
            this.btnSample = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
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
            this.lblPath.Location = new System.Drawing.Point(9, 38);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(84, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "No Zip Selected";
            // 
            // OpenZip
            // 
            this.OpenZip.FileName = "assets_p";
            this.OpenZip.Filter = "Any File|*.*|Zip File|*.zip|Assets File|*.dat|Any Archive|*zip;*.dat";
            this.OpenZip.FilterIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 59);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(209, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Please select an Assets archive to Analyze";
            // 
            // btnAboutThisExploit
            // 
            this.btnAboutThisExploit.Location = new System.Drawing.Point(93, 12);
            this.btnAboutThisExploit.Name = "btnAboutThisExploit";
            this.btnAboutThisExploit.Size = new System.Drawing.Size(105, 23);
            this.btnAboutThisExploit.TabIndex = 3;
            this.btnAboutThisExploit.Text = "About This Exploit";
            this.btnAboutThisExploit.UseVisualStyleBackColor = true;
            this.btnAboutThisExploit.Click += new System.EventHandler(this.btnAboutThisExploit_Click);
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(204, 12);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(94, 23);
            this.btnSample.TabIndex = 4;
            this.btnSample.Text = "Get Sample Zip";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(508, 12);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(75, 23);
            this.btnAuthors.TabIndex = 5;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 88);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.btnAboutThisExploit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cmdChooseZip);
            this.Name = "UserForm";
            this.Text = "Midnight Club 2 Assets Archive Checker";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdChooseZip;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog OpenZip;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAboutThisExploit;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Button btnAuthors;
    }
}