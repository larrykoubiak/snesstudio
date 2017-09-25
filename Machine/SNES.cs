/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 23/11/2015
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CPU;
using ROM;
using MMIO;
using System.IO;


namespace Machine {
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class SNES {
		private ROMImage _rom;
		public ROMImage ROM 
		{ 
			get { return _rom; }
			set {
				_rom = value;
				Reset();
			}
		}

		
		public Ricoh5A22 CPU { get; set;}

		public SNES() : this(null) {
    	}
		
    	public SNES(string ROMfilepath) {
			LoadCPUFromConfig("Ricoh5A22.xml");
			if(ROMfilepath==null || !File.Exists(ROMfilepath)) {
    			ROM = null;    			
    		}
    		else {
    			ROM = new ROMImage(ROMfilepath);
    			CPU.MMU.ROM = ROM;
    			Reset();
    		}
    	}
        public void Reset() {
			CPU.Reset();
        	CPU.PC = ROM.ResetVector;
        }
    	public void Step() {
			CPU.ExecuteCurrentOpcode();
    	}
		
		private void LoadCPUFromConfig(string path)
		{
			XmlSerializer serial;
			serial = new XmlSerializer(typeof(Ricoh5A22));
			FileStream s = new FileStream(path,FileMode.Open);
			CPU = (Ricoh5A22)serial.Deserialize(s);
			s.Close();
			CPU.MMU = new MMU();			
		}
		
		public void SaveCPUConfig(string path)
		{
			XmlSerializer serial;
			serial = new XmlSerializer(typeof(Ricoh5A22));
			XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
			ns.Add("","");
			FileStream s = new FileStream(path,FileMode.Create);
			serial.Serialize(s,CPU,ns);
			s.Close();		
		}
	}
}