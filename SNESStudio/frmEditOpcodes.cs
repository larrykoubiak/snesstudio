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
using System.Reflection;
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

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(
                (dataGridView2.Rows[e.RowIndex].DataBoundItem != null) &&
                (dataGridView2.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(
                    dataGridView2.Rows[e.RowIndex].DataBoundItem,
                    dataGridView2.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private object BindProperty(object property, string propertyName)
        {
            object retValue = null;
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null);
            }
            return retValue;
        }
    }
}
