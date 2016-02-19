/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 12/02/2016
 * Time: 14:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CPU
{
	/// <summary>
	/// Description of Opcode.
	/// </summary>
	public class Opcode
	{
		public byte Id {get;set;}
		public Instruction Instruction16Bit {get;set;}
		public Instruction Instruction8Bit {get;set;}
		public AddressingMode AddressingMode {get;set;}		
		public Opcode()
    	{
    	}
	}
}
