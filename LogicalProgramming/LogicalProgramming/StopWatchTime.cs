using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgramming
{
    internal class StopWatchTime
    {
		
		public void calculateTime()
        { 
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Timer start now...\nWait....and press 'y' key to stop timer ");

            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                stopwatch.Stop();
            }
            TimeSpan time = stopwatch.Elapsed;
            Console.WriteLine("\nElapsed Time is {0:00}m:{1:00}s", time.Minutes, time.Seconds);
        }
	}
}
