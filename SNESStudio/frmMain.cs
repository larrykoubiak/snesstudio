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
using Machine; 
namespace SNESStudio {
    public partial class frmMain : Form {
		#region Members
        private SNESProject project;
        private SNES snes;
        private SNESFile currentFile;
        #endregion

        #region Properties
        public SNESProject Project {
            get { return project; }
        }
        #endregion

        #region Constructor
        public frmMain() {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void mnuFileNewProject_Click(object sender, EventArgs e) {
            frmNewProject dlg = new frmNewProject();
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK) {
                project = new SNESProject();
                project.Name = dlg.ProjectName;
                project.Path = dlg.ProjectFolder;
                RefreshProject();
            }
        }

        private void mnuFileOpenProject_Click(object sender, EventArgs e) {
            string filename;
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "snp";
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "SNES Project file (*.snp)|*.snp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                filename = openFileDialog1.FileName;
                FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(SNESProject));
                project = (SNESProject)serializer.Deserialize(stream);
                project.Path = Path.GetDirectoryName(filename);
                stream.Close();
                RefreshProject();
                SNESFile romfile = project.Files.SingleOrDefault(x => x.SNESType == SNESFileType.ROM);
                if(romfile!=null) {
                	snes = new SNES(Path.Combine(romfile.Path,romfile.FileName));
                	RefreshCPU();
                }
            }
        }

        private void mnuFileSaveProject_Click(object sender, EventArgs e) {
            if (project != null) {
                if (!Directory.Exists(project.Path)) {
                    Directory.CreateDirectory(project.Path);
                }
                string filename = Path.Combine(project.Path, project.Name + ".snp");
                FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                XmlSerializer serializer = new XmlSerializer(typeof(SNESProject));
                serializer.Serialize(stream, project);
                stream.Close();
            }
        }

        private void mnuFileQuit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mnuProjectAddSource_Click(object sender, EventArgs e) {
            frmNewSource dlg = new frmNewSource();
            dlg.Owner = this;
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK) {
                project.Files.Add(new SNESFile(dlg.Filename, "\\.", SNESFileType.Source));
            }
            RefreshProject();
        }

        private void mnuProjectAddROM_Click(object sender, EventArgs e) {
            string filename;
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "snp";
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "SNES ROM file (*.sfc)|*.sfc";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                filename = openFileDialog1.FileName;
	           SNESFile romfile = project.Files.SingleOrDefault(x => x.SNESType == SNESFileType.ROM);
	            if(romfile!=null) {
	            	project.Files[project.Files.IndexOf(romfile)] = new SNESFile(openFileDialog1.SafeFileName, filename, SNESFileType.ROM);
	            }
	            else {
	            	romfile = new SNESFile(openFileDialog1.SafeFileName, Path.GetDirectoryName(filename), SNESFileType.ROM);
    	            project.Files.Add(romfile);	            	
	            }
	            snes = new SNES(Path.Combine(romfile.Path,romfile.FileName));
	            RefreshCPU();
                RefreshProject();
            }
        }

		private void OpcodesToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
        
        private void tvFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            TreeNode clickednode = e.Node;
            if (clickednode.Tag != null) {
                currentFile = (SNESFile)clickednode.Tag;
                switch (currentFile.SNESType) {
                    case SNESFileType.ROM:
                		propertyGrid1.SelectedObject = snes.ROM;
                        break;
                    default:
                        propertyGrid1.SelectedObject = currentFile;
                        break;
                }
            }
            else {
                propertyGrid1.SelectedObject = project;
            }
        }

        private void tvFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            TreeNode clickednode = e.Node;
            if (clickednode.Tag != null) {
                switch (currentFile.SNESType) {
                    case SNESFileType.Source:
                        if (!tbFiles.TabPages.ContainsKey(clickednode.Name)) {
                            TabPage tp = new TabPage();
                            tp.Name = clickednode.Name;
                            tp.Text = currentFile.FileName;
                            tp.Controls.Add(CreateCPUCodeScintilla());
                            tbFiles.TabPages.Add(tp);
                            tp.Controls[0].Text = File.ReadAllText(currentFile.FileName);
            			}
                        break;
                    case SNESFileType.ROM:
                        if (!tbFiles.TabPages.ContainsKey(clickednode.Name)) {
                            TabPage tp = new TabPage();
                            tp.Name = clickednode.Name;
                            tp.Text = currentFile.FileName;							
                            tp.Controls.Add(CreateCPUCodeScintilla());
                            tbFiles.TabPages.Add(tp);
                            ((Scintilla)tp.Controls[0]).AddText(snes.CPU.ReadOpcode());
                            btnStep.Enabled = true;
                            btnReset.Enabled = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            RefreshProject();
        }
        
		void BtnStepClick(object sender, EventArgs e)
		{
			snes.CPU.ExecuteCurrentOpcode();
			Scintilla sc = (Scintilla)tbFiles.SelectedTab.Controls[0];
			sc.AddText(Environment.NewLine + snes.CPU.ReadOpcode());
			sc.ScrollCaret();
			RefreshCPU();
		}

		void BtnResetClick(object sender, EventArgs e)
		{
			snes.Reset();
			Scintilla sc = (Scintilla)tbFiles.SelectedTab.Controls[0];
			sc.Text = "";
			sc.AddText(snes.CPU.ReadOpcode());
			RefreshCPU();
		}
		#endregion

        #region Methods
        private void RefreshProject() {
            propertyGrid1.SelectedObject = project;
            tvFiles.Nodes.Clear();
            
            if (project != null) {
                TreeNode rootNode = tvFiles.Nodes.Add("root", project.Name, 0);
                int imageId;
                for (int i = 0; i < project.Files.Count; i++) {
                    switch(project.Files[i].SNESType) {
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

        private void RefreshCPU() {
            txtA.Text = snes.CPU.A.ToString("X2");
            txtB.Text = snes.CPU.B.ToString("X2");
            txtXL.Text = snes.CPU.XL.ToString("X2");
            txtXH.Text = snes.CPU.XH.ToString("X2");
            txtYL.Text = snes.CPU.YL.ToString("X2");
            txtYH.Text = snes.CPU.YH.ToString("X2");
            txtSP.Text = snes.CPU.SP.ToString("X4");
            txtDP.Text = snes.CPU.DP.ToString("X4");
            txtPB.Text = snes.CPU.PB.ToString("X2");
            txtPC.Text = snes.CPU.PC.ToString("X4");
            txtDB.Text = snes.CPU.DB.ToString("X2");
            chkE.Checked = snes.CPU.E;
            chkN.Checked = snes.CPU.P.N;
            chkV.Checked = snes.CPU.P.V;
            chkX.Checked = snes.CPU.P.X;
            chkM.Checked = snes.CPU.P.M;
            chkD.Checked = snes.CPU.P.D;
            chkI.Checked = snes.CPU.P.I;
            chkZ.Checked = snes.CPU.P.Z;
            chkC.Checked = snes.CPU.P.C;
        }
        
        private Scintilla CreateCPUCodeScintilla()
        {
            Scintilla sc = new Scintilla();
            sc.Location = new Point(0,0);
            sc.Dock = DockStyle.Fill;
            sc.Margins[0].Width = 20;
            sc.CaretForeColor = Color.White;
            sc.StyleResetDefault();
            sc.Styles[Style.Default].Font = "Consolas";
            sc.Styles[Style.Default].Size = 10;
            sc.Styles[Style.Default].BackColor = Color.FromArgb(41, 49, 52);
            sc.StyleClearAll();
            sc.Lexer = Lexer.Cpp;
            sc.Styles[Style.Cpp.Word].ForeColor = Color.FromArgb(147, 199, 99);
            sc.Styles[Style.Cpp.Word].Bold = true;
            sc.Styles[Style.Cpp.Identifier].ForeColor = Color.FromArgb(255, 255, 255);
            sc.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(236, 118, 0);
            sc.Styles[Style.Cpp.Number].ForeColor = Color.FromArgb(255, 205, 34);
            sc.Styles[Style.Cpp.Operator].ForeColor = Color.FromArgb(232, 226, 183);
            sc.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(102, 116, 123);
            //CPU Instructions				            
            sc.SetKeywords(0,snes.CPU.GetKeywords());
            return sc;
        }
		void SaveConfigToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = "Opcodes.xml";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "XML file (*.xml)|*.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
            	snes.SaveCPUConfig(saveFileDialog1.FileName);
            }

		}
        #endregion
    }
}
