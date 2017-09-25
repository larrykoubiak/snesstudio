/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 12/02/2016
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CPU
{	
	[Serializable()]
	[XmlInclude(typeof(Ricoh5A22))]
	[XmlRoot("CPU")]
	public abstract class Processor
	{
		public List<Opcode> Opcodes {get; set;}
		public List<AddressingModeId> AddressingModes {get;set;}
		public List<Instruction> Instructions {get;set;}
		
		protected Processor()
		{
			Opcodes = new List<Opcode>();
			AddressingModes = new List<AddressingModeId>();
			Instructions = new List<Instruction>();
		}

		public string GetKeywords()
		{
			string strKeywords = "";
			foreach(Instruction ins in Instructions)
			{
				if(strKeywords.Length >0) strKeywords += " ";
				strKeywords += ins.Name;
			}
			return strKeywords;
		}
	}
}
