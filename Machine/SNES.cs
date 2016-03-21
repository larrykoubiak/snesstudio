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
    	Ricoh5A22 cPU;
    	MMU mMU;
    	ROMImage rOM;
    	
    	public ROMImage ROM {
    		get { return rOM; }
    		set { 
    			rOM = value;
    			Reset();
    		}
    	}
    	public MMU MMU {
    		get { return mMU; }
    		set { mMU = value; }
    	}
    	public Ricoh5A22 CPU {
    		get { return cPU; }
    		set { cPU = value; }
    	}
    	public SNES() : this(null) {    		
    	}
    	public SNES(string romfilepath) {
    		cPU = new Ricoh5A22();
    		mMU = new MMU();
    		if(romfilepath==null || !File.Exists(romfilepath)) {
    			rOM = null;    			
    		}
    		else {
    			rOM = new ROMImage(romfilepath);
    			mMU.ROM = rOM;
    			Reset();
    		}
    	}
        public void Reset() {
        	cPU.PC = ROM.ResetVector;
        }
    	public string Step() {
    		byte opcode = mMU.ReadByte(cPU.PC);
    		AddressingMode am = cPU.GetAddressingMode(opcode);			
    		Instruction ins = CPU.GetOpcodeInstruction(opcode);
    		return ins.Name;
    	}
	}
}