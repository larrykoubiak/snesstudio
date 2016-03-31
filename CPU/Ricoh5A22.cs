using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MMIO;
using CommonTypes;

namespace CPU {
	public class Ricoh5A22 : Processor {
		
		#region Members
        reg16 a;
        reg16 x;
        reg16 y;
        reg24 pc;
        reg16 sp;
        reg16 dp;
        public byte DB {get;set;}
        public StatusRegister P { get;set;}
        public bool E {get;set;}
        public MMU MMU {get;set;}
        private Opcode op;
        private reg24 operand;
        private Instruction ins;
        private byte opsize;
        
        #endregion

        #region Constructor
        public Ricoh5A22() {
            a.uint16_value = 0x0000;
            x.uint16_value = 0x0000;
            y.uint16_value = 0x0000;
            pc.uint24_value = 0x000000;
            sp.uint16_value = 0x0100;
            dp.uint16_value = 0x0000;
            DB = 0x00;
            P = new StatusRegister(0x34);
            E = true;
            MMU = new MMU();
            LoadConfigXML("Opcodes.xml");
        }
        #endregion

        #region Properties
        public byte A {
            get { return a.uint8_value; }
            set { a.uint8_value = value; }
        }
        public byte B {
            get { return a.h; }
            set { a.h = value; }
        }
        public ushort C {
            get { return a.uint16_value; }
            set { a.uint16_value = value; }
        }
        public byte XL {
            get { return x.uint8_value; }
            set { x.uint8_value = value; }
        }
        public byte XH {
            get { return x.h; }
            set { x.h = value; }
        }
        public ushort X {
            get { return x.uint16_value; }
            set { x.uint16_value = value; }
        }
        public byte YL {
            get { return y.uint8_value; }
            set { y.uint8_value = value; }
        }
        public byte YH {
            get { return y.h; }
            set { y.h = value; }
        }
        public ushort Y {
            get { return y.uint16_value; }
            set { y.uint16_value = value; }
        }
        public ushort PC {
            get { return pc.uint16_value; }
            set { pc.uint16_value = value; }
        }
        public byte PB {
            get { return pc.b; }
            set { pc.b = value; }
        }
        public uint PCL {
            get { return pc.uint24_value; }
            set { pc.uint24_value = value; }
        }
        public ushort SP {
            get { return sp.uint16_value; }
            set { sp.uint16_value = value; }
        }
        public ushort DP {
            get { return dp.uint16_value; }
            set { dp.uint16_value = value; }
        }
        #endregion

		#region Public Methods
        public string ReadOpcode() {
        	byte opcode = MMU.ReadByte(PCL);
    		op = Opcodes[opcode];
    		ins = E ? op.Instruction8Bit : op.Instruction16Bit;
    		opsize = (ins.M && P.M || ins.X && P.X) ? op.AddressingMode.InputLength8Bit : op.AddressingMode.InputLength16Bit;
    		operand = MMU.Read24(PCL + 1,opsize);
    		string format = (ins.M && P.M || ins.X && P.X) ? op.AddressingMode.Format8Bit : op.AddressingMode.Format16Bit;
    		return string.Format("{0:X6} : ",PCL) + string.Format(format,ins.Name,operand.uint24_value);
        }
		
		public void ExecuteCurrentOpcode()
		{
			PC++;
			PC+=opsize;
			TranslateOperand();
    		switch (ins.Name) {
    			case "CLC":
    				P.C = false;
    				break;
    			case "JMP":
    				PCL = operand.uint24_value;
    				break;
    			case "JSR":
    				MMU.WRAM[SP--] = pc.b;
    				MMU.WRAM[SP--] = pc.h;
    				MMU.WRAM[SP--] = pc.uint8_value;
    				PC = operand.uint16_value;
    				break;
    			case "REP":
    				P.Value &= (byte)(~operand.uint8_value);
    				break;
    			case "SEI":
    				P.I = true;
    				break;
    			case "SEP":
    				P.Value |= operand.uint8_value;
    				break;
    			case "XCE":
    				bool E2 = E;
    				E = P.C;
    				P.C = E2;
    				break;
    			default:
    				break;
    		}
		}
		#endregion

		#region Private Methods
		private reg24 TranslateOperand() 
		{
			reg24 newoperand = new reg24();
			AddressingMode am = op.AddressingMode;
			switch(am.Indirection) {
				case "Immediate":
					newoperand = operand;
					break;
				case "Direct":
					switch(am.Addressing) {
						case "Implied":
							break;
						case "Absolute":
							switch(am.Indexed) {
								case "NA":
									newoperand = operand;
									break;
								case "X":
									newoperand.uint24_value = (ushort)(operand.uint24_value + (P.M ? XL : X));
									break;
								case "Y":
									newoperand.uint24_value = (ushort)(operand.uint24_value + (P.M ? XL : X));
									break;
							}
							break;
						case "Direct Page":
							switch(am.Indexed) {
								case "NA":
									newoperand.uint24_value = (ushort)(DP + operand.uint8_value);
									break;
								case "X":
									newoperand.uint24_value = (ushort)((DP + operand.uint8_value) + (P.M ? XL : X));
									break;
								case "Y":
									newoperand.uint24_value = (ushort)((DP + operand.uint8_value) + (P.M ? XL : X));
									break;
							}
							break;
						case "Program Counter":
							newoperand.uint24_value = (uint)(PCL + operand.int24_value);
							break;
						default:
							return operand;
					}
					break;
				case "Indirect":
					//TO DO
					break;
				default:					
					break;
			}
			return newoperand;
		}
		private void UpdateFlags(reg24 result)
		{
			//to do
		}
		#endregion
    }
}
