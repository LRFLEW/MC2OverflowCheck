using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace MC2OverflowCheck
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void cmdChooseZip_Click(object sender, EventArgs e)
        {
            OpenZip.CheckFileExists = true;

            OpenZip.ShowDialog();
            if (File.Exists(OpenZip.FileName)) {
                lblPath.Text = OpenZip.FileName;
            }
            var result = CheckZip.Check(OpenZip.FileName);
            lblMessage.ForeColor = Color.Black;
            lblMessage.BackColor = this.BackColor;
            lblMessage.Font = new Font(lblMessage.Font.Name, 8.25f, FontStyle.Regular);
            switch (result)
            {
                case CheckZip.EvalResult.Incompatible:
                    lblMessage.Text = "This archive is not compatible with the game - either ";
                    return;
                case CheckZip.EvalResult.Invalid:
                    lblMessage.Text = "This ZIP does not follow the ISO Standard for Zip, and so the game will not load it.";
                    return;
                case CheckZip.EvalResult.Optimized:
                    lblMessage.Text = "This is the default archive that comes with the game. It is safe.";
                    return;
                case CheckZip.EvalResult.Unsafe:
                    lblMessage.Text = "This Archive WILL execute arbitrary code if you load it in the game.";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.BackColor = Color.Black;
                    lblMessage.Font = new Font(lblMessage.Font.Name, lblMessage.Font.Size+ 5, FontStyle.Bold);
                    return;
                case CheckZip.EvalResult.Valid:
                    lblMessage.Text = "This Archive is most likely safe to use in the game, and should work in the game.";
                    return;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }
        public partial class CustomLabel : Label
        {
            private TextRenderingHint _hint = TextRenderingHint.SystemDefault;
            public TextRenderingHint TextRenderingHint
            {
                get { return this._hint; }
                set { this._hint = value; }
            }

            protected override void OnPaint(PaintEventArgs pe)
            {
                pe.Graphics.TextRenderingHint = TextRenderingHint;
                base.OnPaint(pe);
            }
        }

        private void btnAboutThisExploit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Dialog Box will be replaced with a link to a webpage or wiki entry about the exploit.");
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Dialog Box will be replaced with a save prompt for an imbedded copy of the exploit zip.");
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }
    }
}
