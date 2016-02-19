using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Data;

namespace CPU {
	public class Ricoh5A22 : Processor {
		
		#region Members
=======

namespace CPU
{
    public class Ricoh5A22
    {
        #region Members
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        reg16 a;
        reg16 x;
        reg16 y;
        reg24 pc;
        reg16 sp;
        reg16 dp;
        byte db;
        StatusRegister p;
        bool e;
        #endregion

        #region Constructor
<<<<<<< HEAD
        public Ricoh5A22() {
=======
        public Ricoh5A22()
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            a.value = 0x0000;
            x.value = 0x0000;
            y.value = 0x0000;
            pc.value = 0x000000;
            sp.value = 0x0100;
            dp.value = 0x0000;
            db = 0x00;
            p = new StatusRegister(0x34);
            e = true;
<<<<<<< HEAD
            //dataset = new dataroot();
            LoadConfigXML("Opcodes.xml");
=======
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        }
        #endregion

        #region Properties
<<<<<<< HEAD
        public byte A {
            get { return a.l; }
            set { a.l = value; }
        }
        public byte B {
            get { return a.h; }
            set { a.h = value; }
        }
        public ushort C {
            get { return a.value; }
            set { a.value = value; }
        }
        public byte XL {
            get { return x.l; }
            set { x.l = value; }
        }
        public byte XH {
            get { return x.h; }
            set { x.h = value; }
        }
        public ushort X {
            get { return x.value; }
            set { x.value = value; }
        }
        public byte YL {
            get { return y.l; }
            set { y.l = value; }
        }
        public byte YH {
            get { return y.h; }
            set { y.h = value; }
        }
        public ushort Y {
            get { return y.value; }
            set { y.value = value; }
        }
        public ushort PC {
            get { return pc.lvalue; }
            set { pc.lvalue = value; }
        }
        public byte PB {
            get { return pc.b; }
            set { pc.b = value; }
        }
        public uint PCL {
            get { return pc.value; }
            set { pc.value = value; }
        }
        public ushort SP {
            get { return sp.value; }
            set { sp.value = value; }
        }
        public ushort DP {
            get { return dp.value; }
            set { dp.value = value; }
        }
        public byte DB {
            get { return db; }
            set { db = value; }
        }
        public StatusRegister P {
            get { return p; }
        }
        public bool E {
            get { return e; }
            set { e = value; }
        }
        public Instruction GetOpcodeInstruction(byte opcode)
        {
        	return E ? Opcodes[opcode].Instruction16Bit : Opcodes[opcode].Instruction8Bit;
        }
        public AddressingMode GetAddressingMode(byte opcode)
        {
        	return Opcodes[opcode].AddressingMode;
        }
=======
        public byte A
        {
            get { return a.l; }
            set { a.l = value; }
        }
        public byte B
        {
            get { return a.h; }
            set { a.h = value; }
        }
        public ushort C
        {
            get { return a.value; }
            set { a.value = value; }
        }
        public byte XL
        {
            get { return x.l; }
            set { x.l = value; }
        }
        public byte XH
        {
            get { return x.h; }
            set { x.h = value; }
        }
        public ushort X
        {
            get { return x.value; }
            set { x.value = value; }
        }
        public byte YL
        {
            get { return y.l; }
            set { y.l = value; }
        }
        public byte YH
        {
            get { return y.h; }
            set { y.h = value; }
        }
        public ushort Y
        {
            get { return y.value; }
            set { y.value = value; }
        }
        public ushort PC
        {
            get { return pc.lvalue; }
            set { pc.lvalue = value; }
        }
        public byte PB
        {
            get { return pc.b; }
            set { pc.b = value; }
        }
        public uint PCL
        {
            get { return pc.value; }
            set { pc.value = value; }
        }
        public ushort SP
        {
            get { return sp.value; }
            set { sp.value = value; }
        }
        public ushort DP
        {
            get { return dp.value; }
            set { dp.value = value; }
        }
        public byte DB
        {
            get { return db; }
            set { db = value; }
        }
        public StatusRegister P
        {
            get { return p; }
        }
        public bool E
        {
            get { return e; }
            set { e = value; }
        }
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        #endregion
    }
}
