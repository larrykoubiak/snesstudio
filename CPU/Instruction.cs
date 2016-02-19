/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 12/02/2016
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CPU
{
	/// <summary>
	/// Description of Instruction.
	/// </summary>
	public class Instruction
	{
		public byte Id {get;set;}
		public string Constant {get;set;}
		public String Name {get;set;}
		public string Description {get;set;}
		public byte Flags {get;set;}
		public bool M {get;set;}
		public bool X {get;set;}
		public bool Branch {get;set;}
		public Instruction()
		{
		}
	}
}
