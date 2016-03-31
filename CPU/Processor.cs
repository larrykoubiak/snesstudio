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
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace CPU
{
	/// <summary>
	/// Description of Processor.
	/// </summary>
	public abstract class Processor
	{
		public List<Opcode> Opcodes {get; set;}
		public List<AddressingMode> AddressingModes {get;set;}
		public List<Instruction> Instructions {get;set;}
		
		public void LoadConfigXML(string path)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(path);
			//load addressing modes
			AddressingModes = new List<AddressingMode>();
			XmlSerializer serial = new XmlSerializer(typeof(AddressingMode));
			XmlNode nodeAddressingModes = doc.SelectSingleNode("/CPU/AddressingModes");
			foreach(XmlNode nodeAM in nodeAddressingModes.SelectNodes("AddressingMode"))
	        {
				AddressingMode am = (AddressingMode)serial.Deserialize(new StringReader(nodeAM.OuterXml));
				AddressingModes.Add(am);
	        }
			Instructions = new List<Instruction>();
			XmlNode nodeInstructions = doc.SelectSingleNode("/CPU/Instructions");
			serial = new XmlSerializer(typeof(Instruction));
			foreach(XmlNode nodeIN in nodeInstructions.SelectNodes("Instruction"))
	        {
				Instruction instruction = (Instruction)serial.Deserialize(new StringReader(nodeIN.OuterXml));
				Instructions.Add(instruction);
	        }
			Opcodes = new List<Opcode>();
			XmlNode nodeOpcodes = doc.SelectSingleNode("/CPU/Opcodes");
			foreach (XmlNode nodeOP in nodeOpcodes.SelectNodes("Opcode"))
			{
				Opcode opcode = new Opcode();
				opcode.Id = byte.Parse(nodeOP.ChildNodes[0].InnerText);
				opcode.Instruction16Bit = Instructions[int.Parse(nodeOP.ChildNodes[1].InnerText)];
				opcode.Instruction8Bit = Instructions[int.Parse(nodeOP.ChildNodes[2].InnerText)];
				opcode.AddressingMode = AddressingModes[int.Parse(nodeOP.ChildNodes[3].InnerText)];
				Opcodes.Add(opcode);
			}
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
