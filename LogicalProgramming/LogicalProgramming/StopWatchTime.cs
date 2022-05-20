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
		Stopwatch stopwatch = new Stopwatch();
		public void calculateTime()
		{
			stopwatch.Start();
            //Thread.Sleep(2000);
            Console.WriteLine("Wait....and pres 'y' key to stop timer ");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                stopwatch.Stop();
            }
            TimeSpan time = stopwatch.Elapsed;
            Console.WriteLine("\nElapsed Time is {0:00}m:{1:00}s", time.Minutes, time.Seconds);
        }
	}
}
