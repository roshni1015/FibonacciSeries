using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logical_Programs
{
    internal class StopwatchProgram
    {
        public void stopWatch()
        {
           
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine("choose the option 1 to start ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1 )
                {
                   stopwatch.Start();
                }

                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(1);

                }
                Console.WriteLine("choose the option 2 to stop");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 2)
                {
                    stopwatch.Stop();
                }
                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);


        }
    }
}
