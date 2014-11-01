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
    public partial class frmNewProject : Form
    {
        private string projectname;
        private string projectfolder;
        public string ProjectName
        {
            get { return projectname; }
        }
        public string ProjectFolder
        {
            get { return projectfolder; }
        }
        public frmNewProject()
        {
            InitializeComponent();
            projectname = "";
            projectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                MessageBox.Show(this, "Please fill in a project name", "Incorrect Project Name");
            }
            else
            {
                projectname = txtProjectName.Text;
                projectfolder = txtProjectFolder.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            txtProjectFolder.Text = System.IO.Path.Combine(projectfolder, txtProjectName.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                projectfolder = folderBrowserDialog1.SelectedPath;
                txtProjectFolder.Text = System.IO.Path.Combine(projectfolder, txtProjectName.Text);
            }
        }
    }
}
