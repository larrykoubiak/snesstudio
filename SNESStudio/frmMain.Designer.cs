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
<<<<<<< HEAD
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
        	this.mnuProjectAddROM = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.chkC = new System.Windows.Forms.CheckBox();
        	this.chkZ = new System.Windows.Forms.CheckBox();
        	this.chkI = new System.Windows.Forms.CheckBox();
        	this.chkD = new System.Windows.Forms.CheckBox();
        	this.chkM = new System.Windows.Forms.CheckBox();
        	this.chkX = new System.Windows.Forms.CheckBox();
        	this.chkV = new System.Windows.Forms.CheckBox();
        	this.chkN = new System.Windows.Forms.CheckBox();
        	this.chkE = new System.Windows.Forms.CheckBox();
        	this.label16 = new System.Windows.Forms.Label();
        	this.txtPC = new System.Windows.Forms.TextBox();
        	this.label14 = new System.Windows.Forms.Label();
        	this.txtPB = new System.Windows.Forms.TextBox();
        	this.label15 = new System.Windows.Forms.Label();
        	this.label13 = new System.Windows.Forms.Label();
        	this.txtDB = new System.Windows.Forms.TextBox();
        	this.txtDP = new System.Windows.Forms.TextBox();
        	this.label12 = new System.Windows.Forms.Label();
        	this.txtSP = new System.Windows.Forms.TextBox();
        	this.label11 = new System.Windows.Forms.Label();
        	this.txtYH = new System.Windows.Forms.TextBox();
        	this.label8 = new System.Windows.Forms.Label();
        	this.label9 = new System.Windows.Forms.Label();
        	this.txtYL = new System.Windows.Forms.TextBox();
        	this.label10 = new System.Windows.Forms.Label();
        	this.txtXH = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.txtXL = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtB = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.txtA = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.tbFiles = new System.Windows.Forms.TabControl();
        	this.tvFiles = new System.Windows.Forms.TreeView();
        	this.imageList1 = new System.Windows.Forms.ImageList(this.components);
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.btnStep = new System.Windows.Forms.Button();
        	this.menuStrip1.SuspendLayout();
        	this.statusStrip1.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.panel1.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.panel2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuFile,
			this.projectToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
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
        	this.mnuFile.Text = "&File";
        	// 
        	// mnuFileNewProject
        	// 
        	this.mnuFileNewProject.Name = "mnuFileNewProject";
        	this.mnuFileNewProject.Size = new System.Drawing.Size(143, 22);
        	this.mnuFileNewProject.Text = "&New Project";
        	this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
        	// 
        	// mnuFileOpenProject
        	// 
        	this.mnuFileOpenProject.Name = "mnuFileOpenProject";
        	this.mnuFileOpenProject.Size = new System.Drawing.Size(143, 22);
        	this.mnuFileOpenProject.Text = "&Open Project";
        	this.mnuFileOpenProject.Click += new System.EventHandler(this.mnuFileOpenProject_Click);
        	// 
        	// mnuFileSaveProject
        	// 
        	this.mnuFileSaveProject.Name = "mnuFileSaveProject";
        	this.mnuFileSaveProject.Size = new System.Drawing.Size(143, 22);
        	this.mnuFileSaveProject.Text = "&Save Project";
        	this.mnuFileSaveProject.Click += new System.EventHandler(this.mnuFileSaveProject_Click);
        	// 
        	// mnuFileQuit
        	// 
        	this.mnuFileQuit.Name = "mnuFileQuit";
        	this.mnuFileQuit.Size = new System.Drawing.Size(143, 22);
        	this.mnuFileQuit.Text = "&Quit";
        	this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
        	// 
        	// projectToolStripMenuItem
        	// 
        	this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuProjectAddSource,
			this.mnuProjectAddROM});
        	this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
        	this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
        	this.projectToolStripMenuItem.Text = "&Project";
        	// 
        	// mnuProjectAddSource
        	// 
        	this.mnuProjectAddSource.Name = "mnuProjectAddSource";
        	this.mnuProjectAddSource.Size = new System.Drawing.Size(135, 22);
        	this.mnuProjectAddSource.Text = "Add &Source";
        	this.mnuProjectAddSource.Click += new System.EventHandler(this.mnuProjectAddSource_Click);
        	// 
        	// mnuProjectAddROM
        	// 
        	this.mnuProjectAddROM.Name = "mnuProjectAddROM";
        	this.mnuProjectAddROM.Size = new System.Drawing.Size(135, 22);
        	this.mnuProjectAddROM.Text = "Add &ROM";
        	this.mnuProjectAddROM.Click += new System.EventHandler(this.mnuProjectAddROM_Click);
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
        	this.statusStrip1.Size = new System.Drawing.Size(1350, 21);
        	this.statusStrip1.TabIndex = 2;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 16);
        	this.toolStripStatusLabel1.Text = "Ready";
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 3;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
        	this.tableLayoutPanel1.Controls.Add(this.propertyGrid1, 0, 2);
        	this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
        	this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
        	this.tableLayoutPanel1.Controls.Add(this.tbFiles, 1, 1);
        	this.tableLayoutPanel1.Controls.Add(this.tvFiles, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 2);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 4;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 620);
        	this.tableLayoutPanel1.TabIndex = 3;
        	// 
        	// propertyGrid1
        	// 
        	this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        	this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.propertyGrid1.Location = new System.Drawing.Point(3, 315);
        	this.propertyGrid1.Name = "propertyGrid1";
        	this.propertyGrid1.Size = new System.Drawing.Size(208, 281);
        	this.propertyGrid1.TabIndex = 7;
        	this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.groupBox1);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(1113, 28);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(234, 281);
        	this.panel1.TabIndex = 6;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.groupBox2);
        	this.groupBox1.Controls.Add(this.chkE);
        	this.groupBox1.Controls.Add(this.label16);
        	this.groupBox1.Controls.Add(this.txtPC);
        	this.groupBox1.Controls.Add(this.label14);
        	this.groupBox1.Controls.Add(this.txtPB);
        	this.groupBox1.Controls.Add(this.label15);
        	this.groupBox1.Controls.Add(this.label13);
        	this.groupBox1.Controls.Add(this.txtDB);
        	this.groupBox1.Controls.Add(this.txtDP);
        	this.groupBox1.Controls.Add(this.label12);
        	this.groupBox1.Controls.Add(this.txtSP);
        	this.groupBox1.Controls.Add(this.label11);
        	this.groupBox1.Controls.Add(this.txtYH);
        	this.groupBox1.Controls.Add(this.label8);
        	this.groupBox1.Controls.Add(this.label9);
        	this.groupBox1.Controls.Add(this.txtYL);
        	this.groupBox1.Controls.Add(this.label10);
        	this.groupBox1.Controls.Add(this.txtXH);
        	this.groupBox1.Controls.Add(this.label5);
        	this.groupBox1.Controls.Add(this.label6);
        	this.groupBox1.Controls.Add(this.txtXL);
        	this.groupBox1.Controls.Add(this.label7);
        	this.groupBox1.Controls.Add(this.txtB);
        	this.groupBox1.Controls.Add(this.label4);
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.txtA);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.groupBox1.Location = new System.Drawing.Point(0, 0);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(234, 281);
        	this.groupBox1.TabIndex = 3;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "CPU";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.chkC);
        	this.groupBox2.Controls.Add(this.chkZ);
        	this.groupBox2.Controls.Add(this.chkI);
        	this.groupBox2.Controls.Add(this.chkD);
        	this.groupBox2.Controls.Add(this.chkM);
        	this.groupBox2.Controls.Add(this.chkX);
        	this.groupBox2.Controls.Add(this.chkV);
        	this.groupBox2.Controls.Add(this.chkN);
        	this.groupBox2.Location = new System.Drawing.Point(9, 126);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(200, 65);
        	this.groupBox2.TabIndex = 45;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "P";
        	// 
        	// chkC
        	// 
        	this.chkC.AutoSize = true;
        	this.chkC.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkC.Location = new System.Drawing.Point(176, 19);
        	this.chkC.Name = "chkC";
        	this.chkC.Size = new System.Drawing.Size(18, 31);
        	this.chkC.TabIndex = 53;
        	this.chkC.Text = "C";
        	this.chkC.UseVisualStyleBackColor = true;
        	// 
        	// chkZ
        	// 
        	this.chkZ.AutoSize = true;
        	this.chkZ.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkZ.Location = new System.Drawing.Point(152, 19);
        	this.chkZ.Name = "chkZ";
        	this.chkZ.Size = new System.Drawing.Size(18, 31);
        	this.chkZ.TabIndex = 52;
        	this.chkZ.Text = "Z";
        	this.chkZ.UseVisualStyleBackColor = true;
        	// 
        	// chkI
        	// 
        	this.chkI.AutoSize = true;
        	this.chkI.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkI.Location = new System.Drawing.Point(131, 19);
        	this.chkI.Name = "chkI";
        	this.chkI.Size = new System.Drawing.Size(15, 31);
        	this.chkI.TabIndex = 51;
        	this.chkI.Text = "I";
        	this.chkI.UseVisualStyleBackColor = true;
        	// 
        	// chkD
        	// 
        	this.chkD.AutoSize = true;
        	this.chkD.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkD.Location = new System.Drawing.Point(106, 19);
        	this.chkD.Name = "chkD";
        	this.chkD.Size = new System.Drawing.Size(19, 31);
        	this.chkD.TabIndex = 50;
        	this.chkD.Text = "D";
        	this.chkD.UseVisualStyleBackColor = true;
        	// 
        	// chkM
        	// 
        	this.chkM.AutoSize = true;
        	this.chkM.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkM.Location = new System.Drawing.Point(81, 19);
        	this.chkM.Name = "chkM";
        	this.chkM.Size = new System.Drawing.Size(20, 31);
        	this.chkM.TabIndex = 49;
        	this.chkM.Text = "M";
        	this.chkM.UseVisualStyleBackColor = true;
        	// 
        	// chkX
        	// 
        	this.chkX.AutoSize = true;
        	this.chkX.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkX.Location = new System.Drawing.Point(56, 19);
        	this.chkX.Name = "chkX";
        	this.chkX.Size = new System.Drawing.Size(18, 31);
        	this.chkX.TabIndex = 48;
        	this.chkX.Text = "X";
        	this.chkX.UseVisualStyleBackColor = true;
        	// 
        	// chkV
        	// 
        	this.chkV.AutoSize = true;
        	this.chkV.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkV.Location = new System.Drawing.Point(31, 19);
        	this.chkV.Name = "chkV";
        	this.chkV.Size = new System.Drawing.Size(18, 31);
        	this.chkV.TabIndex = 47;
        	this.chkV.Text = "V";
        	this.chkV.UseVisualStyleBackColor = true;
        	// 
        	// chkN
        	// 
        	this.chkN.AutoSize = true;
        	this.chkN.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkN.Location = new System.Drawing.Point(6, 19);
        	this.chkN.Name = "chkN";
        	this.chkN.Size = new System.Drawing.Size(19, 31);
        	this.chkN.TabIndex = 46;
        	this.chkN.Text = "N";
        	this.chkN.UseVisualStyleBackColor = true;
        	// 
        	// chkE
        	// 
        	this.chkE.AutoSize = true;
        	this.chkE.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        	this.chkE.Location = new System.Drawing.Point(110, 84);
        	this.chkE.Name = "chkE";
        	this.chkE.Size = new System.Drawing.Size(18, 31);
        	this.chkE.TabIndex = 44;
        	this.chkE.Text = "E";
        	this.chkE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	this.chkE.UseVisualStyleBackColor = true;
        	// 
        	// label16
        	// 
        	this.label16.AutoSize = true;
        	this.label16.Location = new System.Drawing.Point(65, 84);
        	this.label16.Name = "label16";
        	this.label16.Size = new System.Drawing.Size(21, 13);
        	this.label16.TabIndex = 43;
        	this.label16.Text = "PC";
        	// 
        	// txtPC
        	// 
        	this.txtPC.Location = new System.Drawing.Point(61, 100);
        	this.txtPC.Name = "txtPC";
        	this.txtPC.Size = new System.Drawing.Size(35, 20);
        	this.txtPC.TabIndex = 42;
        	// 
        	// label14
        	// 
        	this.label14.AutoSize = true;
        	this.label14.Location = new System.Drawing.Point(6, 104);
        	this.label14.Name = "label14";
        	this.label14.Size = new System.Drawing.Size(27, 13);
        	this.label14.TabIndex = 41;
        	this.label14.Text = "PCL";
        	// 
        	// txtPB
        	// 
        	this.txtPB.Location = new System.Drawing.Point(36, 100);
        	this.txtPB.Name = "txtPB";
        	this.txtPB.Size = new System.Drawing.Size(22, 20);
        	this.txtPB.TabIndex = 40;
        	// 
        	// label15
        	// 
        	this.label15.AutoSize = true;
        	this.label15.Location = new System.Drawing.Point(37, 84);
        	this.label15.Name = "label15";
        	this.label15.Size = new System.Drawing.Size(21, 13);
        	this.label15.TabIndex = 39;
        	this.label15.Text = "PB";
        	// 
        	// label13
        	// 
        	this.label13.AutoSize = true;
        	this.label13.Location = new System.Drawing.Point(155, 61);
        	this.label13.Name = "label13";
        	this.label13.Size = new System.Drawing.Size(22, 13);
        	this.label13.TabIndex = 38;
        	this.label13.Text = "DB";
        	// 
        	// txtDB
        	// 
        	this.txtDB.Location = new System.Drawing.Point(178, 58);
        	this.txtDB.Name = "txtDB";
        	this.txtDB.Size = new System.Drawing.Size(22, 20);
        	this.txtDB.TabIndex = 37;
        	// 
        	// txtDP
        	// 
        	this.txtDP.Location = new System.Drawing.Point(110, 58);
        	this.txtDP.Name = "txtDP";
        	this.txtDP.Size = new System.Drawing.Size(35, 20);
        	this.txtDP.TabIndex = 36;
        	// 
        	// label12
        	// 
        	this.label12.AutoSize = true;
        	this.label12.Location = new System.Drawing.Point(82, 61);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(22, 13);
        	this.label12.TabIndex = 35;
        	this.label12.Text = "DP";
        	// 
        	// txtSP
        	// 
        	this.txtSP.Location = new System.Drawing.Point(36, 58);
        	this.txtSP.Name = "txtSP";
        	this.txtSP.Size = new System.Drawing.Size(35, 20);
        	this.txtSP.TabIndex = 34;
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Location = new System.Drawing.Point(6, 61);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(21, 13);
        	this.label11.TabIndex = 33;
        	this.label11.Text = "SP";
        	// 
        	// txtYH
        	// 
        	this.txtYH.Location = new System.Drawing.Point(203, 32);
        	this.txtYH.Name = "txtYH";
        	this.txtYH.Size = new System.Drawing.Size(22, 20);
        	this.txtYH.TabIndex = 32;
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(203, 16);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(22, 13);
        	this.label8.TabIndex = 31;
        	this.label8.Text = "YH";
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(161, 32);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(14, 13);
        	this.label9.TabIndex = 30;
        	this.label9.Text = "Y";
        	// 
        	// txtYL
        	// 
        	this.txtYL.Location = new System.Drawing.Point(178, 32);
        	this.txtYL.Name = "txtYL";
        	this.txtYL.Size = new System.Drawing.Size(22, 20);
        	this.txtYL.TabIndex = 29;
        	// 
        	// label10
        	// 
        	this.label10.AutoSize = true;
        	this.label10.Location = new System.Drawing.Point(183, 16);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(20, 13);
        	this.label10.TabIndex = 28;
        	this.label10.Text = "YL";
        	// 
        	// txtXH
        	// 
        	this.txtXH.Location = new System.Drawing.Point(135, 32);
        	this.txtXH.Name = "txtXH";
        	this.txtXH.Size = new System.Drawing.Size(22, 20);
        	this.txtXH.TabIndex = 27;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(135, 16);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(22, 13);
        	this.label5.TabIndex = 26;
        	this.label5.Text = "XH";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(90, 35);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(14, 13);
        	this.label6.TabIndex = 25;
        	this.label6.Text = "X";
        	// 
        	// txtXL
        	// 
        	this.txtXL.Location = new System.Drawing.Point(110, 32);
        	this.txtXL.Name = "txtXL";
        	this.txtXL.Size = new System.Drawing.Size(22, 20);
        	this.txtXL.TabIndex = 24;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(110, 16);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(20, 13);
        	this.label7.TabIndex = 23;
        	this.label7.Text = "XL";
        	// 
        	// txtB
        	// 
        	this.txtB.Location = new System.Drawing.Point(61, 32);
        	this.txtB.Name = "txtB";
        	this.txtB.Size = new System.Drawing.Size(22, 20);
        	this.txtB.TabIndex = 22;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(65, 16);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(14, 13);
        	this.label4.TabIndex = 21;
        	this.label4.Text = "B";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(6, 35);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(14, 13);
        	this.label3.TabIndex = 20;
        	this.label3.Text = "C";
        	// 
        	// txtA
        	// 
        	this.txtA.Location = new System.Drawing.Point(36, 32);
        	this.txtA.Name = "txtA";
        	this.txtA.Size = new System.Drawing.Size(22, 20);
        	this.txtA.TabIndex = 19;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(41, 16);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(14, 13);
        	this.label2.TabIndex = 18;
        	this.label2.Text = "A";
        	// 
        	// label1
        	// 
        	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(3, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(64, 13);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Properties";
        	// 
        	// tbFiles
        	// 
        	this.tbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tbFiles.Location = new System.Drawing.Point(217, 28);
        	this.tbFiles.Name = "tbFiles";
        	this.tableLayoutPanel1.SetRowSpan(this.tbFiles, 2);
        	this.tbFiles.SelectedIndex = 0;
        	this.tbFiles.Size = new System.Drawing.Size(890, 568);
        	this.tbFiles.TabIndex = 4;
        	// 
        	// tvFiles
        	// 
        	this.tvFiles.Cursor = System.Windows.Forms.Cursors.Default;
        	this.tvFiles.Dock = System.Windows.Forms.DockStyle.Top;
        	this.tvFiles.ImageIndex = 0;
        	this.tvFiles.ImageList = this.imageList1;
        	this.tvFiles.Location = new System.Drawing.Point(3, 28);
        	this.tvFiles.Name = "tvFiles";
        	this.tvFiles.SelectedImageIndex = 0;
        	this.tvFiles.Size = new System.Drawing.Size(208, 277);
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
        	this.imageList1.Images.SetKeyName(2, "Chip.png");
        	// 
        	// panel2
        	// 
        	this.panel2.Controls.Add(this.btnStep);
        	this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel2.Location = new System.Drawing.Point(1113, 315);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(234, 281);
        	this.panel2.TabIndex = 8;
        	// 
        	// btnStep
        	// 
        	this.btnStep.Location = new System.Drawing.Point(3, 3);
        	this.btnStep.Name = "btnStep";
        	this.btnStep.Size = new System.Drawing.Size(55, 23);
        	this.btnStep.TabIndex = 0;
        	this.btnStep.Text = "Step";
        	this.btnStep.UseVisualStyleBackColor = true;
        	this.btnStep.Click += new System.EventHandler(this.BtnStepClick);
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1350, 620);
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
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.panel2.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
=======
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
            this.tbFiles = new System.Windows.Forms.TabControl();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkE = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkN = new System.Windows.Forms.CheckBox();
            this.chkV = new System.Windows.Forms.CheckBox();
            this.chkX = new System.Windows.Forms.CheckBox();
            this.chkM = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkI = new System.Windows.Forms.CheckBox();
            this.chkZ = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.mnuProjectAddROM = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
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
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewProject
            // 
            this.mnuFileNewProject.Name = "mnuFileNewProject";
            this.mnuFileNewProject.Size = new System.Drawing.Size(152, 22);
            this.mnuFileNewProject.Text = "&New Project";
            this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
            // 
            // mnuFileOpenProject
            // 
            this.mnuFileOpenProject.Name = "mnuFileOpenProject";
            this.mnuFileOpenProject.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOpenProject.Text = "&Open Project";
            this.mnuFileOpenProject.Click += new System.EventHandler(this.mnuFileOpenProject_Click);
            // 
            // mnuFileSaveProject
            // 
            this.mnuFileSaveProject.Name = "mnuFileSaveProject";
            this.mnuFileSaveProject.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveProject.Text = "&Save Project";
            this.mnuFileSaveProject.Click += new System.EventHandler(this.mnuFileSaveProject_Click);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectAddSource,
            this.mnuProjectAddROM});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "&Project";
            // 
            // mnuProjectAddSource
            // 
            this.mnuProjectAddSource.Name = "mnuProjectAddSource";
            this.mnuProjectAddSource.Size = new System.Drawing.Size(152, 22);
            this.mnuProjectAddSource.Text = "Add &Source";
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
            this.statusStrip1.Size = new System.Drawing.Size(1350, 21);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.propertyGrid1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFiles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tvFiles, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 620);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1113, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 281);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Properties";
            // 
            // tbFiles
            // 
            this.tbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFiles.Location = new System.Drawing.Point(217, 28);
            this.tbFiles.Name = "tbFiles";
            this.tableLayoutPanel1.SetRowSpan(this.tbFiles, 2);
            this.tbFiles.SelectedIndex = 0;
            this.tbFiles.Size = new System.Drawing.Size(890, 568);
            this.tbFiles.TabIndex = 4;
            // 
            // tvFiles
            // 
            this.tvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvFiles.ImageIndex = 0;
            this.tvFiles.ImageList = this.imageList1;
            this.tvFiles.Location = new System.Drawing.Point(3, 28);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.SelectedImageIndex = 0;
            this.tvFiles.Size = new System.Drawing.Size(208, 277);
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
            this.imageList1.Images.SetKeyName(2, "Chip.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkE);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPC);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPB);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtDP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtYH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtYL);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtXH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtXL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // txtYH
            // 
            this.txtYH.Location = new System.Drawing.Point(203, 32);
            this.txtYH.Name = "txtYH";
            this.txtYH.Size = new System.Drawing.Size(22, 20);
            this.txtYH.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "YH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Y";
            // 
            // txtYL
            // 
            this.txtYL.Location = new System.Drawing.Point(178, 32);
            this.txtYL.Name = "txtYL";
            this.txtYL.Size = new System.Drawing.Size(22, 20);
            this.txtYL.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "YL";
            // 
            // txtXH
            // 
            this.txtXH.Location = new System.Drawing.Point(127, 32);
            this.txtXH.Name = "txtXH";
            this.txtXH.Size = new System.Drawing.Size(22, 20);
            this.txtXH.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "XH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "X";
            // 
            // txtXL
            // 
            this.txtXL.Location = new System.Drawing.Point(102, 32);
            this.txtXL.Name = "txtXL";
            this.txtXL.Size = new System.Drawing.Size(22, 20);
            this.txtXL.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "XL";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(54, 32);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(22, 20);
            this.txtB.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(29, 32);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(22, 20);
            this.txtA.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "SP";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(29, 58);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(35, 20);
            this.txtSP.TabIndex = 34;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(102, 58);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(35, 20);
            this.txtDP.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "DP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "DB";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(164, 58);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(22, 20);
            this.txtDB.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "PCL";
            // 
            // txtPB
            // 
            this.txtPB.Location = new System.Drawing.Point(29, 100);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(22, 20);
            this.txtPB.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "PB";
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(54, 100);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(35, 20);
            this.txtPC.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "PC";
            // 
            // chkE
            // 
            this.chkE.AutoSize = true;
            this.chkE.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkE.Location = new System.Drawing.Point(170, 103);
            this.chkE.Name = "chkE";
            this.chkE.Size = new System.Drawing.Size(33, 17);
            this.chkE.TabIndex = 44;
            this.chkE.Text = "E";
            this.chkE.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkC);
            this.groupBox2.Controls.Add(this.chkZ);
            this.groupBox2.Controls.Add(this.chkI);
            this.groupBox2.Controls.Add(this.chkD);
            this.groupBox2.Controls.Add(this.chkM);
            this.groupBox2.Controls.Add(this.chkX);
            this.groupBox2.Controls.Add(this.chkV);
            this.groupBox2.Controls.Add(this.chkN);
            this.groupBox2.Location = new System.Drawing.Point(9, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 65);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P";
            // 
            // chkN
            // 
            this.chkN.AutoSize = true;
            this.chkN.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkN.Location = new System.Drawing.Point(6, 19);
            this.chkN.Name = "chkN";
            this.chkN.Size = new System.Drawing.Size(19, 31);
            this.chkN.TabIndex = 46;
            this.chkN.Text = "N";
            this.chkN.UseVisualStyleBackColor = true;
            // 
            // chkV
            // 
            this.chkV.AutoSize = true;
            this.chkV.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkV.Location = new System.Drawing.Point(31, 19);
            this.chkV.Name = "chkV";
            this.chkV.Size = new System.Drawing.Size(18, 31);
            this.chkV.TabIndex = 47;
            this.chkV.Text = "V";
            this.chkV.UseVisualStyleBackColor = true;
            // 
            // chkX
            // 
            this.chkX.AutoSize = true;
            this.chkX.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkX.Location = new System.Drawing.Point(56, 19);
            this.chkX.Name = "chkX";
            this.chkX.Size = new System.Drawing.Size(18, 31);
            this.chkX.TabIndex = 48;
            this.chkX.Text = "X";
            this.chkX.UseVisualStyleBackColor = true;
            // 
            // chkM
            // 
            this.chkM.AutoSize = true;
            this.chkM.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkM.Location = new System.Drawing.Point(81, 19);
            this.chkM.Name = "chkM";
            this.chkM.Size = new System.Drawing.Size(20, 31);
            this.chkM.TabIndex = 49;
            this.chkM.Text = "M";
            this.chkM.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkD.Location = new System.Drawing.Point(106, 19);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(19, 31);
            this.chkD.TabIndex = 50;
            this.chkD.Text = "D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // chkI
            // 
            this.chkI.AutoSize = true;
            this.chkI.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkI.Location = new System.Drawing.Point(131, 19);
            this.chkI.Name = "chkI";
            this.chkI.Size = new System.Drawing.Size(15, 31);
            this.chkI.TabIndex = 51;
            this.chkI.Text = "I";
            this.chkI.UseVisualStyleBackColor = true;
            // 
            // chkZ
            // 
            this.chkZ.AutoSize = true;
            this.chkZ.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkZ.Location = new System.Drawing.Point(152, 19);
            this.chkZ.Name = "chkZ";
            this.chkZ.Size = new System.Drawing.Size(18, 31);
            this.chkZ.TabIndex = 52;
            this.chkZ.Text = "Z";
            this.chkZ.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkC.Location = new System.Drawing.Point(176, 19);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(18, 31);
            this.chkC.TabIndex = 53;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // mnuProjectAddROM
            // 
            this.mnuProjectAddROM.Name = "mnuProjectAddROM";
            this.mnuProjectAddROM.Size = new System.Drawing.Size(152, 22);
            this.mnuProjectAddROM.Text = "Add &ROM";
            this.mnuProjectAddROM.Click += new System.EventHandler(this.mnuProjectAddROM_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 315);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(208, 281);
            this.propertyGrid1.TabIndex = 7;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 620);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7

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
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.TabControl tbFiles;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectAddSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkE;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkZ;
        private System.Windows.Forms.CheckBox chkI;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkM;
        private System.Windows.Forms.CheckBox chkX;
        private System.Windows.Forms.CheckBox chkV;
        private System.Windows.Forms.CheckBox chkN;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectAddROM;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
<<<<<<< HEAD
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStep;
=======
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
    }
}

