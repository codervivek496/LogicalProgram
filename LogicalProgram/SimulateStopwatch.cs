using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgram
{
    internal class SimulateStopwatch
    {
        public void Stopwatch()
        {
            //importing Stopwatch class
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Press any key to strat stopwatch");
            Console.ReadKey();
            stopWatch.Start();

            //Thread.Sleep(10000);

            Console.WriteLine("Press any key to stop stopwatch");
            Console.ReadKey();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}