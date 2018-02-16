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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Application was \r\nwritten by LRFLEW and Krutonium.\r\n\r\nThis program and its s" +
    "ource code is \r\ndistributed under the MIT licence\r\n\r\nYou can find more applicati" +
    "ons from each of us:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnklblLRFLEW
            // 
            this.lnklblLRFLEW.AutoSize = true;
            this.lnklblLRFLEW.Location = new System.Drawing.Point(83, 116);
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
            this.lnklblKrutonium.Location = new System.Drawing.Point(144, 116);
            this.lnklblKrutonium.Name = "lnklblKrutonium";
            this.lnklblKrutonium.Size = new System.Drawing.Size(54, 13);
            this.lnklblKrutonium.TabIndex = 2;
            this.lnklblKrutonium.TabStop = true;
            this.lnklblKrutonium.Text = "Krutonium";
            this.lnklblKrutonium.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblKrutonium_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MC2OverflowCheck.Properties.Resources.overflow;
            this.pictureBox1.Location = new System.Drawing.Point(86, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnklblKrutonium);
            this.Controls.Add(this.lnklblLRFLEW);
            this.Controls.Add(this.label1);
            this.Name = "AboutBox";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblLRFLEW;
        private System.Windows.Forms.LinkLabel lnklblKrutonium;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}