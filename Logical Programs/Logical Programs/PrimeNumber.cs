using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class PrimeNumber
    {
        public void primenumber()
        {
            int num, g, x = 0, y = 0;
            Console.Write("Enter the Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            x = num / 2;
            for (g = 2; g <= x; g++)
            {
                if (num % g == 0)
                {
                    Console.Write("Number is not Prime.");
                    y = 1;
                    break;
                }
            }
            if (y == 0)
                Console.WriteLine("Number is Prime.");
        }
    }
}
   
    
