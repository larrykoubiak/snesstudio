using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

<<<<<<< HEAD
namespace SNESStudio {
    public partial class frmNewSource : Form {
        private string filename;
        public string Filename {
            get { return filename; }
        }
        public frmNewSource() {
            InitializeComponent();
            filename = "";
        }
        private void btnOK_Click(object sender, EventArgs e) {
            if (txtFileName.Text.Length > 0) {
                filename = txtFileName.Text;
                this.DialogResult = DialogResult.OK;
            }
            else {
=======
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
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
                MessageBox.Show(this, "Please enter a source file name", "Incorrect file name");
            }
        }

<<<<<<< HEAD
        private void btnCancel_Click(object sender, EventArgs e) {
=======
        private void btnCancel_Click(object sender, EventArgs e)
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
