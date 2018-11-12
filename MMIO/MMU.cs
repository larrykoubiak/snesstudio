/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 23/11/2015
 * Time: 10:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using ROM;
using CommonTypes;

namespace MMIO {
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public enum LayoutType {
		LOROM = 1,
		HIROM = 2
	}
	public class MMU {
		LayoutType layout;
		ROMImage rom;
		byte[] wRAM;
		byte[] aRAM;
		byte[] vRAM;
		byte[] oAM;
		reg24 address;
		
		public byte[] OAM {
			get { return oAM; }
			set { oAM = value; }
		}
		
		public byte[] VRAM {
			get { return vRAM; }
			set { vRAM = value; }
		}
		
		public byte[] ARAM {
			get { return aRAM; }
			set { aRAM = value; }
		}
		
		public byte[] WRAM {
			get { return wRAM; }
			set { wRAM = value; }
		}
		public ROMImage ROM {
			get { return rom; }
			set { 
				rom = value;
				if(rom.Layout.Contains("LoRom"))
					layout = LayoutType.LOROM;
				else
					layout = LayoutType.HIROM;
			}
		}
		public LayoutType Layout { 
			get { return layout;}
			set { layout=value; }
		}
				
		public MMU() {
			rom = null;
			Reset();
		}
		
		public void Reset() {
			wRAM = new byte[0x20000];
			aRAM = new byte[0x10000];
			vRAM = new byte[0x10000];
			oAM = new byte[0x220];			
		}
		public byte ReadByte(uint loc) {
			address.uint24_value = loc;
			switch(address.b) {
				case 0x7E:
				case 0x7F:
					return wRAM[address.uint16_value];
				default:
					switch(layout) {
						case LayoutType.HIROM:
							if((address.b>=0x40 && address.b<=0x7D) || (address.b >=0xC0 && address.b <=0xFF)) {
						   		return rom[address.uint24_value & 0x3FFFFF];
						    }
							else {
								if(address.h >=0x80)
									return rom[address.uint24_value & 0x3FFFFF];
								else {
									if(address.h >=0x00 && address.h <= 0x1F) {
										return wRAM[address.uint16_value];
									}
									else {
										return 0;
									}
								}
							}
						case LayoutType.LOROM:
							if(address.h >= 0x80) {
								address.b &= 0x7F;
								address.b /=2;
								address.uint16_value &=0x7FFF;
								return rom[address.uint24_value];
							}
							else {
								if(address.h >=0x00 && address.h <=0x1F) {
									return wRAM[address.uint16_value];
								}
								else {
									return 0;
								}
							}
						default:
							return 0;
					}
			}
		}
		public byte[] ReadBytes(uint loc, byte length)
		{
			byte[] buf = new byte[length];
			for(byte idx =0; idx<length;idx++)
			{
				buf[idx] = ReadByte(loc+idx);				
			}
			return buf;
		}
        public reg16 Read16(uint loc)
        {
            reg16 buf = new reg16();
            buf.uint8_value = ReadByte(loc);
            buf.h = ReadByte(loc + 1);
            return buf;
        }
		public reg24 Read24(uint loc,byte length)
		{
			byte idx = 0;
			reg24 buf = new reg24();
			if(length>0) buf.uint8_value = ReadByte(loc+idx++);
			if(length>1) buf.h = ReadByte(loc+idx++);
			if(length>2) buf.b = ReadByte(loc+idx++);
			return buf;
		}

		
	}
}