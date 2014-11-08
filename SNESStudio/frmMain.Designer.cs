namespace SNESStudio
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectAddSource = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tbFiles = new System.Windows.Forms.TabControl();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewProject,
            this.mnuFileOpenProject,
            this.mnuFileSaveProject,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNewProject
            // 
            this.mnuFileNewProject.Name = "mnuFileNewProject";
            this.mnuFileNewProject.Size = new System.Drawing.Size(143, 22);
            this.mnuFileNewProject.Text = "New Project";
            this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
            // 
            // mnuFileOpenProject
            // 
            this.mnuFileOpenProject.Name = "mnuFileOpenProject";
            this.mnuFileOpenProject.Size = new System.Drawing.Size(143, 22);
            this.mnuFileOpenProject.Text = "Open Project";
            this.mnuFileOpenProject.Click += new System.EventHandler(this.mnuFileOpenProject_Click);
            // 
            // mnuFileSaveProject
            // 
            this.mnuFileSaveProject.Name = "mnuFileSaveProject";
            this.mnuFileSaveProject.Size = new System.Drawing.Size(143, 22);
            this.mnuFileSaveProject.Text = "Save Project";
            this.mnuFileSaveProject.Click += new System.EventHandler(this.mnuFileSaveProject_Click);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(143, 22);
            this.mnuFileQuit.Text = "Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectAddSource});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // mnuProjectAddSource
            // 
            this.mnuProjectAddSource.Name = "mnuProjectAddSource";
            this.mnuProjectAddSource.Size = new System.Drawing.Size(135, 22);
            this.mnuProjectAddSource.Text = "Add Source";
            this.mnuProjectAddSource.Click += new System.EventHandler(this.mnuProjectAddSource_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1289, 20);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 15);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFiles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tvFiles, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 620);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1092, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 568);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Properties";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 277);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(194, 291);
            this.propertyGrid1.TabIndex = 1;
            // 
            // tbFiles
            // 
            this.tbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFiles.Location = new System.Drawing.Point(168, 28);
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.SelectedIndex = 0;
            this.tbFiles.Size = new System.Drawing.Size(918, 568);
            this.tbFiles.TabIndex = 4;
            // 
            // tvFiles
            // 
            this.tvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFiles.ImageIndex = 0;
            this.tvFiles.ImageList = this.imageList1;
            this.tvFiles.Location = new System.Drawing.Point(3, 28);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.SelectedImageIndex = 0;
            this.tvFiles.Size = new System.Drawing.Size(159, 568);
            this.tvFiles.TabIndex = 5;
            this.tvFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFiles_NodeMouseClick);
            this.tvFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFiles_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "snes.ico");
            this.imageList1.Images.SetKeyName(1, "text_icon.ico");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 620);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "SNES Studio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.TabControl tbFiles;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectAddSource;
    }
}

