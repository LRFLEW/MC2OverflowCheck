using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MC2OverflowCheck
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void lnklblLRFLEW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/LRFLEW/");
        }

        private void lnklblKrutonium_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Krutonium/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.overflow_uIn_icon;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
