using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SNESStudio
{
    public partial class frmNewSource : Form
    {
        private string filename;
        public string Filename
        {
            get { return filename; }
        }
        public frmNewSource()
        {
            InitializeComponent();
            filename = "";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length > 0)
            {
                filename = txtFileName.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "Please enter a source file name", "Incorrect file name");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
