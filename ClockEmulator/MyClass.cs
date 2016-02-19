/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 10/11/2015
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClockEmulator
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Clock
	{
		private Stopwatch watch;
		int frequency;
		
		public int Frequency {
			get { return frequency; }
			set { frequency = value; }
		}
		
		public long ElapsedNanoseconds
		{
			get { return watch.ElapsedTicks ;}
		}
		
		public Clock()
		{
			frequency = 0;
			watch = new Stopwatch();
		}
		
		public Clock(int freq)
		{
			frequency = freq;
		}
		
		
	}
}