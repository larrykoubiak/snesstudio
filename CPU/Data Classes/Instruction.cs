/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 12/02/2016
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml.Serialization;

namespace CPU
{
	/// <summary>
	/// Description of Instruction.
	/// </summary>
	public class Instruction
	{
		private StatusRegister srFlags;
		public byte Id {get;set;}
		public string Constant {get;set;}
		public String Name {get;set;}
		public string Description {get;set;}
		public byte Flags 
		{
			get { return srFlags.Value;}
			set { srFlags.Value = value;}
		}
		public bool M {get;set;}
		public bool X {get;set;}
		public bool Branch {get;set;}
		[XmlIgnore]
		public StatusRegister Registers {
			get { return srFlags;}
		}
		public Instruction()
		{
			srFlags = new StatusRegister();
		}
	}
}
