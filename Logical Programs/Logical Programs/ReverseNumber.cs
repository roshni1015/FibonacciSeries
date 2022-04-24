using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class ReverseNumber
    {
        public void reversenumber()
        {
            int num, x, reverse = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                x = num % 10;
                reverse = reverse * 10 + x;
                num /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
