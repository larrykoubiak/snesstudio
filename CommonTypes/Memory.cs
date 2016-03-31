/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 21/03/2016
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CommonTypes
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
    [StructLayout(LayoutKind.Explicit,Size =2,Pack=1)]
    public struct reg16 {
        [FieldOffset(0)]
        public byte uint8_value;
        [FieldOffset(1)]
        public byte h;
        [FieldOffset(0)]
        public sbyte int8_value;
        [FieldOffset(0)]
        public ushort uint16_value;
        [FieldOffset(0)]
        public short int16_value;
    }
    
    [StructLayout(LayoutKind.Explicit,Size =3,Pack =1)]
    public struct reg24 {
        [FieldOffset(0)]
        public byte uint8_value;
        [FieldOffset(1)]
        public byte h;
        [FieldOffset(2)]
        public byte b;
/*        [FieldOffset(3)]
        public byte bh;*/
        [FieldOffset(0)]
        public sbyte int8_value;
        [FieldOffset(0)]
        public ushort uint16_value;
        [FieldOffset(0)]
        public short int16_value;
        [FieldOffset(0)]
        public uint uint24_value;
        [FieldOffset(0)]
        public int int24_value;        
    }
}