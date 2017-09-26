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
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewComboBoxColumn colAddressingMode;
		private System.Windows.Forms.DataGridViewComboBoxColumn colInstruction65816;
		private System.Windows.Forms.DataGridViewComboBoxColumn colInstruction6502;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpOpcodes = new System.Windows.Forms.TabPage();
			this.dgvOpcodes = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInstruction65816 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colInstruction6502 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colAddressingMode = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.tpAddressingModes = new System.Windows.Forms.TabPage();
			this.tpInstructions = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpOpcodes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOpcodes)).BeginInit();
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 507);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(869, 485);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(54, 19);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(929, 485);
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
			this.tabControl1.Size = new System.Drawing.Size(980, 476);
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
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			// 
			// colInstruction65816
			// 
			this.colInstruction65816.DataPropertyName = "InstructionId65816";
			this.colInstruction65816.HeaderText = "Instruction 65816";
			this.colInstruction65816.Name = "colInstruction65816";
			// 
			// colInstruction6502
			// 
			this.colInstruction6502.DataPropertyName = "InstructionId6502";
			this.colInstruction6502.HeaderText = "Instruction 6502";
			this.colInstruction6502.Name = "colInstruction6502";
			// 
			// colAddressingMode
			// 
			this.colAddressingMode.DataPropertyName = "AddressingModeId";
			this.colAddressingMode.HeaderText = "Addressing Mode";
			this.colAddressingMode.Name = "colAddressingMode";
			// 
			// tpAddressingModes
			// 
			this.tpAddressingModes.Location = new System.Drawing.Point(4, 22);
			this.tpAddressingModes.Name = "tpAddressingModes";
			this.tpAddressingModes.Padding = new System.Windows.Forms.Padding(3);
			this.tpAddressingModes.Size = new System.Drawing.Size(972, 450);
			this.tpAddressingModes.TabIndex = 1;
			this.tpAddressingModes.Text = "Addressing Modes";
			this.tpAddressingModes.UseVisualStyleBackColor = true;
			// 
			// tpInstructions
			// 
			this.tpInstructions.Location = new System.Drawing.Point(4, 22);
			this.tpInstructions.Name = "tpInstructions";
			this.tpInstructions.Size = new System.Drawing.Size(972, 450);
			this.tpInstructions.TabIndex = 2;
			this.tpInstructions.Text = "Instructions";
			this.tpInstructions.UseVisualStyleBackColor = true;
			// 
			// frmEditOpcodes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(986, 507);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmEditOpcodes";
			this.Text = "Edit Opcodes";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tpOpcodes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOpcodes)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
