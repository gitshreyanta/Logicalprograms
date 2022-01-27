using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;


namespace LogicalPrograms
{
    class DemoStopwatch
    {
        public void Watch()
        {
            // Create new stopwatch obj 
            Stopwatch stopwatch = new Stopwatch();


            Console.WriteLine("click to start the watch");
            Console.ReadLine();

            // Start stopwatch time
            stopwatch.Start();


            Console.WriteLine("click to stop the watch");
            Console.ReadLine();

            // Stop time
            stopwatch.Stop();

            // Print the total Elapsed time
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
