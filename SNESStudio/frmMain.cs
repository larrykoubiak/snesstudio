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
using CPU;
using ROM;
namespace SNESStudio
{
    public partial class frmMain : Form
    {
        #region Members
        private SNESProject project;
        private Ricoh5A22 cpu;
        private SNESFile currentFile;
        #endregion

        #region Properties
        public SNESProject Project
        {
            get { return project; }
        }
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            cpu = new Ricoh5A22();
            RefreshCPU();
        }
        #endregion

        #region Event Handlers
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
            if (project != null)
            {
                if (!Directory.Exists(project.Path))
                {
                    Directory.CreateDirectory(project.Path);
                }
                string filename = Path.Combine(project.Path, project.Name + ".snp");
                FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                XmlSerializer serializer = new XmlSerializer(typeof(SNESProject));
                serializer.Serialize(stream, project);
                stream.Close();
            }
        }

        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tvFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickednode = e.Node;
            if (clickednode.Tag != null)
            {
                currentFile = (SNESFile)clickednode.Tag;
                switch (currentFile.SNESType)
                {
                    case SNESFileType.ROM:
                        currentFile = (SNESROMFile)currentFile;
                        propertyGrid1.SelectedObject = currentFile;
                        break;
                    default:
                        propertyGrid1.SelectedObject = currentFile;
                        break;
                }
            }
            else
            {
                propertyGrid1.SelectedObject = project;
            }
        }

        private void tvFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickednode = e.Node;
            if (clickednode.Tag != null)
            {
                switch (currentFile.SNESType)
                {
                    case SNESFileType.Source:
                        if (!tbFiles.TabPages.ContainsKey(clickednode.Name))
                        {
                            TabPage tp = new TabPage();
                            tp.Name = clickednode.Name;
                            tp.Text = currentFile.FileName;
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
                        break;
                    case SNESFileType.ROM:
                        SNESROMFile romfile = (SNESROMFile)propertyGrid1.SelectedObject;
                        MessageBox.Show(romfile.ROM.ROMName + "\n" + romfile.ROM.Layout + "\n" + romfile.ROM.Chipset + "\n" + romfile.ROM.Country + "\n" + romfile.ROM.License);
                        break;
                    default:
                        break;
                }
            }
        }

        private void mnuProjectAddROM_Click(object sender, EventArgs e)
        {
            string filename;
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "snp";
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "SNES ROM file (*.sfc)|*.sfc";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                SNESFile romfile = new SNESFile(openFileDialog1.SafeFileName, filename, SNESFileType.ROM);
                project.Files.Add(romfile);
                RefreshProject();
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            RefreshProject();
        }

        #endregion

        #region Methods
        private void RefreshProject()
        {
            propertyGrid1.SelectedObject = project;
            tvFiles.Nodes.Clear();
            
            if (project != null)
            {
                TreeNode rootNode = tvFiles.Nodes.Add("root", project.Name, 0);
                int imageId;
                for (int i = 0; i < project.Files.Count; i++)
                {
                    switch(project.Files[i].SNESType)
                    {
                        case SNESFileType.Source:
                            imageId = 1;
                            break;
                        case SNESFileType.ROM:
                            imageId = 2;
                            break;
                        default:
                            imageId = 0;
                            break;
                    }
                    TreeNode newnode = rootNode.Nodes.Add(project.Files[i].Path + project.Files[i].FileName, project.Files[i].FileName,imageId, imageId);
                    newnode.Tag = project.Files[i];
                }
                tvFiles.ExpandAll();
            }
        }

        private void RefreshCPU()
        {
            txtA.Text = cpu.A.ToString("X2");
            txtB.Text = cpu.B.ToString("X2");
            txtXL.Text = cpu.XL.ToString("X2");
            txtXH.Text = cpu.XH.ToString("X2");
            txtYL.Text = cpu.YL.ToString("X2");
            txtYH.Text = cpu.YH.ToString("X2");
            txtSP.Text = cpu.SP.ToString("X4");
            txtDP.Text = cpu.DP.ToString("X4");
            txtPB.Text = cpu.PB.ToString("X2");
            txtPC.Text = cpu.PC.ToString("X4");
            txtDB.Text = cpu.DB.ToString("X2");
            chkE.Checked = cpu.E;
            chkN.Checked = cpu.P.N;
            chkV.Checked = cpu.P.V;
            chkX.Checked = cpu.P.X;
            chkM.Checked = cpu.P.M;
            chkD.Checked = cpu.P.D;
            chkI.Checked = cpu.P.I;
            chkZ.Checked = cpu.P.Z;
            chkC.Checked = cpu.P.C;
        }
        #endregion


    }
}
