using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            switch (result)
            {
                case CheckZip.EvalResult.Incompatible:
                    return;
                case CheckZip.EvalResult.Invalid:
                    return;
                case CheckZip.EvalResult.Optimized:
                    return;
                case CheckZip.EvalResult.Unsafe:
                    return;
                case CheckZip.EvalResult.Valid:
                    return;
            }
        }
    }
}
