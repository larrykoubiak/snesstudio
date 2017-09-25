/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 12/02/2016
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml.Serialization;
namespace CPU
{
	/// <summary>
	/// Description of AddressingModeId.
	/// </summary>
	public class AddressingModeId
	{
		public byte Id {get;set;}
		public string Constant {get;set;}
		public string Description {get;set;}
		public string Format8Bit {get;set;}
		public string Format16Bit {get;set;}
		public byte InputLength8Bit {get;set;}
		public byte InputLength16Bit {get;set;}
		public string Addressing {get;set;}
		public string Indirection {get;set;}
		public string Indexed {get;set;}
		public AddressingModeId()
		{
		}
	}
}
