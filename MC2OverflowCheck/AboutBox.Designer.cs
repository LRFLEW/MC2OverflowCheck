namespace MC2OverflowCheck
{
    partial class AboutBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblLRFLEW = new System.Windows.Forms.LinkLabel();
            this.lnklblKrutonium = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Application was \r\nwritten by LRFLEW and Krutonium.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnklblLRFLEW
            // 
            this.lnklblLRFLEW.AutoSize = true;
            this.lnklblLRFLEW.Location = new System.Drawing.Point(12, 239);
            this.lnklblLRFLEW.Name = "lnklblLRFLEW";
            this.lnklblLRFLEW.Size = new System.Drawing.Size(51, 13);
            this.lnklblLRFLEW.TabIndex = 1;
            this.lnklblLRFLEW.TabStop = true;
            this.lnklblLRFLEW.Text = "LRFLEW";
            this.lnklblLRFLEW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLRFLEW_LinkClicked);
            // 
            // lnklblKrutonium
            // 
            this.lnklblKrutonium.AutoSize = true;
            this.lnklblKrutonium.Location = new System.Drawing.Point(221, 239);
            this.lnklblKrutonium.Name = "lnklblKrutonium";
            this.lnklblKrutonium.Size = new System.Drawing.Size(54, 13);
            this.lnklblKrutonium.TabIndex = 2;
            this.lnklblKrutonium.TabStop = true;
            this.lnklblKrutonium.Text = "Krutonium";
            this.lnklblKrutonium.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblKrutonium_LinkClicked);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lnklblKrutonium);
            this.Controls.Add(this.lnklblLRFLEW);
            this.Controls.Add(this.label1);
            this.Name = "AboutBox";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblLRFLEW;
        private System.Windows.Forms.LinkLabel lnklblKrutonium;
    }
}