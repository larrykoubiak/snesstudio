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
			get 
			{
				return _rom;
			}
			set 
			{
				_rom = value;
				Reset();
			}
		}

		
		public Ricoh5A22 CPU { get; set;}

		public SNES() : this(null) {
    	}
		
    	public SNES(string ROMfilepath) {
    		CPU = new Ricoh5A22();
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
        	CPU.PC = ROM.ResetVector;
        }
    	public void Step() {
			CPU.ExecuteCurrentOpcode();
    	}
	}
}