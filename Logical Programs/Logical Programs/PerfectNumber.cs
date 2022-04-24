using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class PerfectNumber
    {
        public void perfectnumber()
        {
            {
                int num, sum = 0, n;
                Console.Write("Enter the Number: ");
                num = Convert.ToInt32(Console.ReadLine());
                n = num;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == n)
                {
                    Console.WriteLine("\n Number is a Perfect number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n Number is not a Perfect number");
                    Console.ReadLine();
                }
            }
        }
    }
}
