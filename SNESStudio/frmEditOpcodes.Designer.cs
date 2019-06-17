/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 26/09/2017
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SNESStudio
{
	partial class frmEditOpcodes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpOpcodes;
		private System.Windows.Forms.DataGridView dgvOpcodes;
		private System.Windows.Forms.TabPage tpAddressingModes;
		private System.Windows.Forms.TabPage tpInstructions;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOpcodes = new System.Windows.Forms.TabPage();
            this.dgvOpcodes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstruction65816 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.instructionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colInstruction6502 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAddressingMode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addressingModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpAddressingModes = new System.Windows.Forms.TabPage();
            this.tpInstructions = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.branchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registersCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registersZDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registersIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registersDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.XRegisterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MRegistersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VRegistersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NRegistersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format8BitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format16BitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputLength8BitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputLength16BitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.indirectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.indexedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpOpcodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressingModeBindingSource)).BeginInit();
            this.tpAddressingModes.SuspendLayout();
            this.tpInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(1007, 485);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 19);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1067, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 19);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 3);
            this.tabControl1.Controls.Add(this.tpOpcodes);
            this.tabControl1.Controls.Add(this.tpAddressingModes);
            this.tabControl1.Controls.Add(this.tpInstructions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 476);
            this.tabControl1.TabIndex = 2;
            // 
            // tpOpcodes
            // 
            this.tpOpcodes.Controls.Add(this.dgvOpcodes);
            this.tpOpcodes.Location = new System.Drawing.Point(4, 22);
            this.tpOpcodes.Name = "tpOpcodes";
            this.tpOpcodes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOpcodes.Size = new System.Drawing.Size(972, 450);
            this.tpOpcodes.TabIndex = 0;
            this.tpOpcodes.Text = "Opcodes";
            this.tpOpcodes.UseVisualStyleBackColor = true;
            // 
            // dgvOpcodes
            // 
            this.dgvOpcodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpcodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpcodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colInstruction65816,
            this.colInstruction6502,
            this.colAddressingMode});
            this.dgvOpcodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOpcodes.Location = new System.Drawing.Point(3, 3);
            this.dgvOpcodes.Name = "dgvOpcodes";
            this.dgvOpcodes.Size = new System.Drawing.Size(966, 444);
            this.dgvOpcodes.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // colInstruction65816
            // 
            this.colInstruction65816.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colInstruction65816.DataPropertyName = "InstructionId65816";
            this.colInstruction65816.DataSource = this.instructionBindingSource;
            this.colInstruction65816.DisplayMember = "Name";
            this.colInstruction65816.HeaderText = "Instruction 65816";
            this.colInstruction65816.Name = "colInstruction65816";
            this.colInstruction65816.ValueMember = "Id";
            this.colInstruction65816.Width = 86;
            // 
            // instructionBindingSource
            // 
            this.instructionBindingSource.DataSource = typeof(CPU.Instruction);
            // 
            // colInstruction6502
            // 
            this.colInstruction6502.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colInstruction6502.DataPropertyName = "InstructionId6502";
            this.colInstruction6502.DataSource = this.instructionBindingSource;
            this.colInstruction6502.DisplayMember = "Name";
            this.colInstruction6502.HeaderText = "Instruction 6502";
            this.colInstruction6502.Name = "colInstruction6502";
            this.colInstruction6502.ValueMember = "Id";
            this.colInstruction6502.Width = 80;
            // 
            // colAddressingMode
            // 
            this.colAddressingMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAddressingMode.DataPropertyName = "AddressingModeId";
            this.colAddressingMode.DataSource = this.addressingModeBindingSource;
            this.colAddressingMode.DisplayMember = "Description";
            this.colAddressingMode.HeaderText = "Addressing Mode";
            this.colAddressingMode.Name = "colAddressingMode";
            this.colAddressingMode.ValueMember = "Id";
            this.colAddressingMode.Width = 86;
            // 
            // addressingModeBindingSource
            // 
            this.addressingModeBindingSource.DataSource = typeof(CPU.AddressingMode);
            // 
            // tpAddressingModes
            // 
            this.tpAddressingModes.Controls.Add(this.dataGridView1);
            this.tpAddressingModes.Location = new System.Drawing.Point(4, 22);
            this.tpAddressingModes.Name = "tpAddressingModes";
            this.tpAddressingModes.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddressingModes.Size = new System.Drawing.Size(1110, 450);
            this.tpAddressingModes.TabIndex = 1;
            this.tpAddressingModes.Text = "Addressing Modes";
            this.tpAddressingModes.UseVisualStyleBackColor = true;
            // 
            // tpInstructions
            // 
            this.tpInstructions.Controls.Add(this.dataGridView2);
            this.tpInstructions.Location = new System.Drawing.Point(4, 22);
            this.tpInstructions.Name = "tpInstructions";
            this.tpInstructions.Size = new System.Drawing.Size(972, 450);
            this.tpInstructions.TabIndex = 2;
            this.tpInstructions.Text = "Instructions";
            this.tpInstructions.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.constantDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.format8BitDataGridViewTextBoxColumn,
            this.format16BitDataGridViewTextBoxColumn,
            this.inputLength8BitDataGridViewTextBoxColumn,
            this.inputLength16BitDataGridViewTextBoxColumn,
            this.addressingDataGridViewTextBoxColumn,
            this.indirectionDataGridViewTextBoxColumn,
            this.indexedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressingModeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.constantDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.flagsDataGridViewTextBoxColumn,
            this.mDataGridViewCheckBoxColumn,
            this.xDataGridViewCheckBoxColumn,
            this.branchDataGridViewCheckBoxColumn,
            this.registersCDataGridViewCheckBoxColumn,
            this.registersZDataGridViewCheckBoxColumn,
            this.registersIDataGridViewCheckBoxColumn,
            this.registersDDataGridViewCheckBoxColumn,
            this.XRegisterDataGridViewCheckBoxColumn,
            this.MRegistersDataGridViewCheckBoxColumn,
            this.VRegistersDataGridViewCheckBoxColumn,
            this.NRegistersDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.instructionBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(972, 450);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // constantDataGridViewTextBoxColumn1
            // 
            this.constantDataGridViewTextBoxColumn1.DataPropertyName = "Constant";
            this.constantDataGridViewTextBoxColumn1.HeaderText = "Constant";
            this.constantDataGridViewTextBoxColumn1.Name = "constantDataGridViewTextBoxColumn1";
            this.constantDataGridViewTextBoxColumn1.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 250;
            // 
            // flagsDataGridViewTextBoxColumn
            // 
            this.flagsDataGridViewTextBoxColumn.DataPropertyName = "Flags";
            this.flagsDataGridViewTextBoxColumn.HeaderText = "Flags";
            this.flagsDataGridViewTextBoxColumn.Name = "flagsDataGridViewTextBoxColumn";
            this.flagsDataGridViewTextBoxColumn.Width = 50;
            // 
            // mDataGridViewCheckBoxColumn
            // 
            this.mDataGridViewCheckBoxColumn.DataPropertyName = "M";
            this.mDataGridViewCheckBoxColumn.HeaderText = "M";
            this.mDataGridViewCheckBoxColumn.Name = "mDataGridViewCheckBoxColumn";
            this.mDataGridViewCheckBoxColumn.Width = 30;
            // 
            // xDataGridViewCheckBoxColumn
            // 
            this.xDataGridViewCheckBoxColumn.DataPropertyName = "X";
            this.xDataGridViewCheckBoxColumn.HeaderText = "X";
            this.xDataGridViewCheckBoxColumn.Name = "xDataGridViewCheckBoxColumn";
            this.xDataGridViewCheckBoxColumn.Width = 30;
            // 
            // branchDataGridViewCheckBoxColumn
            // 
            this.branchDataGridViewCheckBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewCheckBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewCheckBoxColumn.Name = "branchDataGridViewCheckBoxColumn";
            this.branchDataGridViewCheckBoxColumn.Width = 50;
            // 
            // registersCDataGridViewCheckBoxColumn
            // 
            this.registersCDataGridViewCheckBoxColumn.DataPropertyName = "Registers.C";
            this.registersCDataGridViewCheckBoxColumn.HeaderText = "P_C";
            this.registersCDataGridViewCheckBoxColumn.Name = "registersCDataGridViewCheckBoxColumn";
            this.registersCDataGridViewCheckBoxColumn.ReadOnly = true;
            this.registersCDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.registersCDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.registersCDataGridViewCheckBoxColumn.Width = 30;
            // 
            // registersZDataGridViewCheckBoxColumn
            // 
            this.registersZDataGridViewCheckBoxColumn.DataPropertyName = "Registers.Z";
            this.registersZDataGridViewCheckBoxColumn.HeaderText = "P_Z";
            this.registersZDataGridViewCheckBoxColumn.Name = "registersZDataGridViewCheckBoxColumn";
            this.registersZDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.registersZDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.registersZDataGridViewCheckBoxColumn.Width = 30;
            // 
            // registersIDataGridViewCheckBoxColumn
            // 
            this.registersIDataGridViewCheckBoxColumn.DataPropertyName = "Registers.I";
            this.registersIDataGridViewCheckBoxColumn.HeaderText = "P_I";
            this.registersIDataGridViewCheckBoxColumn.Name = "registersIDataGridViewCheckBoxColumn";
            this.registersIDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.registersIDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.registersIDataGridViewCheckBoxColumn.Width = 30;
            // 
            // registersDDataGridViewCheckBoxColumn
            // 
            this.registersDDataGridViewCheckBoxColumn.DataPropertyName = "Registers.D";
            this.registersDDataGridViewCheckBoxColumn.HeaderText = "P_D";
            this.registersDDataGridViewCheckBoxColumn.Name = "registersDDataGridViewCheckBoxColumn";
            this.registersDDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.registersDDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.registersDDataGridViewCheckBoxColumn.Width = 30;
            // 
            // XRegisterDataGridViewCheckBoxColumn
            // 
            this.XRegisterDataGridViewCheckBoxColumn.DataPropertyName = "Registers.M";
            this.XRegisterDataGridViewCheckBoxColumn.HeaderText = "P_X";
            this.XRegisterDataGridViewCheckBoxColumn.Name = "XRegisterDataGridViewCheckBoxColumn";
            this.XRegisterDataGridViewCheckBoxColumn.Width = 30;
            // 
            // MRegistersDataGridViewCheckBoxColumn
            // 
            this.MRegistersDataGridViewCheckBoxColumn.DataPropertyName = "Registers.M";
            this.MRegistersDataGridViewCheckBoxColumn.HeaderText = "P_M";
            this.MRegistersDataGridViewCheckBoxColumn.Name = "MRegistersDataGridViewCheckBoxColumn";
            this.MRegistersDataGridViewCheckBoxColumn.Width = 30;
            // 
            // VRegistersDataGridViewCheckBoxColumn
            // 
            this.VRegistersDataGridViewCheckBoxColumn.DataPropertyName = "Registers.V";
            this.VRegistersDataGridViewCheckBoxColumn.HeaderText = "P_V";
            this.VRegistersDataGridViewCheckBoxColumn.Name = "VRegistersDataGridViewCheckBoxColumn";
            this.VRegistersDataGridViewCheckBoxColumn.Width = 30;
            // 
            // NRegistersDataGridViewCheckBoxColumn
            // 
            this.NRegistersDataGridViewCheckBoxColumn.DataPropertyName = "Registers.N";
            this.NRegistersDataGridViewCheckBoxColumn.HeaderText = "P_N";
            this.NRegistersDataGridViewCheckBoxColumn.Name = "NRegistersDataGridViewCheckBoxColumn";
            this.NRegistersDataGridViewCheckBoxColumn.Width = 30;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // constantDataGridViewTextBoxColumn
            // 
            this.constantDataGridViewTextBoxColumn.DataPropertyName = "Constant";
            this.constantDataGridViewTextBoxColumn.HeaderText = "Constant";
            this.constantDataGridViewTextBoxColumn.Name = "constantDataGridViewTextBoxColumn";
            this.constantDataGridViewTextBoxColumn.Width = 365;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 160;
            // 
            // format8BitDataGridViewTextBoxColumn
            // 
            this.format8BitDataGridViewTextBoxColumn.DataPropertyName = "Format8Bit";
            this.format8BitDataGridViewTextBoxColumn.HeaderText = "Format8Bit";
            this.format8BitDataGridViewTextBoxColumn.Name = "format8BitDataGridViewTextBoxColumn";
            // 
            // format16BitDataGridViewTextBoxColumn
            // 
            this.format16BitDataGridViewTextBoxColumn.DataPropertyName = "Format16Bit";
            this.format16BitDataGridViewTextBoxColumn.HeaderText = "Format16Bit";
            this.format16BitDataGridViewTextBoxColumn.Name = "format16BitDataGridViewTextBoxColumn";
            // 
            // inputLength8BitDataGridViewTextBoxColumn
            // 
            this.inputLength8BitDataGridViewTextBoxColumn.DataPropertyName = "InputLength8Bit";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.inputLength8BitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.inputLength8BitDataGridViewTextBoxColumn.HeaderText = "Len8Bit";
            this.inputLength8BitDataGridViewTextBoxColumn.Name = "inputLength8BitDataGridViewTextBoxColumn";
            this.inputLength8BitDataGridViewTextBoxColumn.Width = 50;
            // 
            // inputLength16BitDataGridViewTextBoxColumn
            // 
            this.inputLength16BitDataGridViewTextBoxColumn.DataPropertyName = "InputLength16Bit";
            this.inputLength16BitDataGridViewTextBoxColumn.HeaderText = "Len16Bit";
            this.inputLength16BitDataGridViewTextBoxColumn.Name = "inputLength16BitDataGridViewTextBoxColumn";
            this.inputLength16BitDataGridViewTextBoxColumn.Width = 50;
            // 
            // addressingDataGridViewTextBoxColumn
            // 
            this.addressingDataGridViewTextBoxColumn.DataPropertyName = "Addressing";
            this.addressingDataGridViewTextBoxColumn.HeaderText = "Addressing";
            this.addressingDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "NA",
            "Absolute",
            "Absolute Long",
            "Block",
            "Direct Page",
            "Immediate",
            "Implied",
            "Program Counter",
            "Stack"});
            this.addressingDataGridViewTextBoxColumn.Name = "addressingDataGridViewTextBoxColumn";
            this.addressingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // indirectionDataGridViewTextBoxColumn
            // 
            this.indirectionDataGridViewTextBoxColumn.DataPropertyName = "Indirection";
            this.indirectionDataGridViewTextBoxColumn.HeaderText = "Indirection";
            this.indirectionDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Direct",
            "Indirect",
            "Immediate"});
            this.indirectionDataGridViewTextBoxColumn.Name = "indirectionDataGridViewTextBoxColumn";
            this.indirectionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.indirectionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.indirectionDataGridViewTextBoxColumn.Width = 75;
            // 
            // indexedDataGridViewTextBoxColumn
            // 
            this.indexedDataGridViewTextBoxColumn.DataPropertyName = "Indexed";
            this.indexedDataGridViewTextBoxColumn.HeaderText = "Indexed";
            this.indexedDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "NA",
            "X",
            "Y"});
            this.indexedDataGridViewTextBoxColumn.Name = "indexedDataGridViewTextBoxColumn";
            this.indexedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.indexedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.indexedDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmEditOpcodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEditOpcodes";
            this.Text = "Edit Opcodes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpOpcodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressingModeBindingSource)).EndInit();
            this.tpAddressingModes.ResumeLayout(false);
            this.tpInstructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.BindingSource instructionBindingSource;
        private System.Windows.Forms.BindingSource addressingModeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn colInstruction65816;
        private System.Windows.Forms.DataGridViewComboBoxColumn colInstruction6502;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddressingMode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn branchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn registersCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn registersZDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn registersIDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn registersDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn XRegisterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MRegistersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VRegistersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NRegistersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn format8BitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn format16BitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputLength8BitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputLength16BitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn indirectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn indexedDataGridViewTextBoxColumn;
    }
}
