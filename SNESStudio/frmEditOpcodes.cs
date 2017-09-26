/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 26/09/2017
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CPU;

namespace SNESStudio
{
	/// <summary>
	/// Description of frmEditOpcodes.
	/// </summary>
	public partial class frmEditOpcodes : Form
	{
		private Processor _cpu;
		public frmEditOpcodes()
		{
			InitializeComponent();
		}
		public frmEditOpcodes(Processor cpu) : this()
		{
			_cpu = cpu;
			((DataGridViewComboBoxColumn)dgvOpcodes.Columns["colAddressingMode"]).DataSource = AddressingModes;
			((DataGridViewComboBoxColumn)dgvOpcodes.Columns["colInstruction65816"]).DataSource = Instructions;
			((DataGridViewComboBoxColumn)dgvOpcodes.Columns["colInstruction6502"]).DataSource = Instructions;

			dgvOpcodes.AutoGenerateColumns = false;
			dgvOpcodes.DataSource = Opcodes;
		}
		public Processor CPU
		{
			get {return _cpu;}
			set {_cpu = value;}
		}
		public BindingList<Opcode> Opcodes
		{
			get { return new BindingList<Opcode>(_cpu.Opcodes);}
		}
		public BindingList<AddressingMode> AddressingModes
		{
			get {return new BindingList<AddressingMode>(_cpu.AddressingModes);}
		}
		public BindingList<Instruction> Instructions
		{
			get {return new BindingList<Instruction>(_cpu.Instructions);}
		}
	}
}
