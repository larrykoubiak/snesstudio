using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ScintillaNET;
namespace SNESStudio
{
    public partial class frmMain : Form
    {
        private SNESProject project;
        public SNESProject Project
        {
            get { return project; }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuFileNewProject_Click(object sender, EventArgs e)
        {
            frmNewProject dlg = new frmNewProject();
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                project = new SNESProject();
                project.Name = dlg.ProjectName;
                project.Path = dlg.ProjectFolder;
                project.Files.Add(new SNESFile());
                RefreshProject();
            }
        }

        private void mnuFileOpenProject_Click(object sender, EventArgs e)
        {
            string filename;
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "snp";
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "SNES Project file (*.snp)|*.snp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(SNESProject));
                project = (SNESProject)serializer.Deserialize(stream);
                project.Path = Path.GetDirectoryName(filename);
                stream.Close();
                RefreshProject();
            }
        }

        private void mnuFileSaveProject_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(project.Path))
            {
                Directory.CreateDirectory(project.Path);
            }
            string filename = Path.Combine(project.Path,project.Name + ".snp");
            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(SNESProject));
            serializer.Serialize(stream, project);
            stream.Close();
        }

        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshProject()
        {
            propertyGrid1.SelectedObject = project;
            tvFiles.Nodes.Clear();
            
            if (project != null)
            {
                TreeNode rootNode = tvFiles.Nodes.Add("root", project.Name, 0);
                for (int i = 0; i < project.Files.Count; i++)
                {
                    TreeNode newnode = rootNode.Nodes.Add(project.Files[i].Path + project.Files[i].FileName, project.Files[i].FileName, 1, 1);
                    newnode.Tag = project.Files[i];
                }
                tvFiles.ExpandAll();
            }
        }

        private void tvFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickednode = e.Node;
            if (clickednode.Tag != null)
            {
                SNESFile file = (SNESFile)clickednode.Tag;
                propertyGrid1.SelectedObject = project.Files[project.Files.IndexOf(file)];
            }
            else
            {
                propertyGrid1.SelectedObject = project;
            }
        }

        private void mnuProjectAddSource_Click(object sender, EventArgs e)
        {
            frmNewSource dlg = new frmNewSource();
            dlg.Owner = this;
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                project.Files.Add(new SNESFile(dlg.Filename, "\\.", SNESFileType.Source));
            }
            RefreshProject();
        }

        private void tvFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickednode = e.Node;
            if (clickednode.Tag != null)
            {
                SNESFile file = (SNESFile)clickednode.Tag;
                if (!tbFiles.TabPages.ContainsKey(clickednode.Name))
                {
                    TabPage tp = new TabPage();
                    tp.Name = clickednode.Name;
                    tp.Text = file.FileName;
                    Scintilla sc = new Scintilla();
                    sc.Lexing.LexerLanguageMap["65816"] = "asm";
                    sc.ConfigurationManager.CustomLocation = System.IO.Path.GetFullPath("65816.xml");
                    sc.ConfigurationManager.Language = "65816";
                    sc.ConfigurationManager.Configure();
                    sc.Location = new System.Drawing.Point(0, 0);
                    sc.Dock = DockStyle.Fill;
                    sc.Margins[0].Width = 20;
                    tp.Controls.Add(sc);
                    tbFiles.TabPages.Add(tp);

                }
            }
        }
    }
}
