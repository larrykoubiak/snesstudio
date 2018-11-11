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
            instructionBindingSource.DataSource = _cpu.Instructions;
            addressingModeBindingSource.DataSource = _cpu.AddressingModes;
            dgvOpcodes.AutoGenerateColumns = false;
			dgvOpcodes.DataSource = _cpu.Opcodes;
		}
		public Processor CPU
		{
			get {return _cpu;}
			set {_cpu = value;}
		}
	}
}
