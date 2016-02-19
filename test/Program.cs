/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 10/11/2015
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Threading;

namespace test
{
	class Program
	{
		[StructLayout(LayoutKind.Explicit,Size=32,Pack=1)]
		public struct test32
		{
			[FieldOffset(0)]
			public byte l;
			[FieldOffset(1)]
			public byte h;
			[FieldOffset(2)]
			public byte xl;
			[FieldOffset(3)]
			public byte xh;
			[FieldOffset(0)]
			public uint Value;
		}
		public static void Main(string[] args)
		{
			BitVector32 vector;
			long elapsedticks,elapsedticks2;
			long tickduration = (1000L*1000L*1000L)/Stopwatch.Frequency;
			test32 test;
			Stopwatch watch;
			BitVector32.Section vl = BitVector32.CreateSection(255);
			BitVector32.Section vh = BitVector32.CreateSection(255,vl);
			BitVector32.Section vxl = BitVector32.CreateSection(255,vh);
			BitVector32.Section vxh = BitVector32.CreateSection(255,vxl);
			vector = new BitVector32();
			vector[vl] = 15;
			vector[vh] = 15;
			vector[vxl] = 15;
			vector[vxh] = 15;
			test = new test32();
			watch = new Stopwatch();
			watch.Restart();
			for(int i=0;i<10;i++)
			{
				vector[vl] = 1;
				vector[vh] = 2;
				vector[vxl] = 4;
				vector[vxh] = 8;
			}
			elapsedticks = (watch.ElapsedTicks);
			Console.Write(String.Format("{0} elapsed nanoseconds (vector)\n",elapsedticks * tickduration));
			watch.Restart();
			for(int j=0;j<10;j++)
			{
				test.l = 1;
				test.h = 2;
				test.xl = 4;
				test.xh = 8;				
			}
			elapsedticks2 = (watch.ElapsedTicks);
			Console.Write(String.Format("{0} elapsed nanoseconds (struct)\n",elapsedticks2 * tickduration));
			watch.Restart();
			for(int i=0;i<10;i++)
			{
				vector[vl] = 8;
				vector[vh] = 4;
				vector[vxl] = 2;
				vector[vxh] = 1;
			}
			elapsedticks = (watch.ElapsedTicks);
			Console.Write(String.Format("{0} elapsed nanoseconds (vector)\n",elapsedticks * tickduration));
			watch.Restart();
			for(int j=0;j<10;j++)
			{
				test.l = 8;
				test.h = 4;
				test.xl = 2;
				test.xh = 1;				
			}
			elapsedticks2 = (watch.ElapsedTicks);
			Console.Write(String.Format("{0} elapsed nanoseconds (struct)\n",elapsedticks2 * tickduration));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void DisplayTimerProperties()
		{
		    // Display the timer frequency and resolution.
		    if (Stopwatch.IsHighResolution)
		    {
		        Console.WriteLine("Operations timed using the system's high-resolution performance counter.");
		    }
		    else 
		    {
		        Console.WriteLine("Operations timed using the DateTime class.");
		    }
		
		    long frequency = Stopwatch.Frequency;
		    Console.WriteLine("  Timer frequency in ticks per second = {0}",
		        frequency);
		    long nanosecPerTick = (1000L*1000L*1000L) / frequency;
		    Console.WriteLine("  Timer is accurate within {0} nanoseconds", 
		        nanosecPerTick);
		}
	}
}