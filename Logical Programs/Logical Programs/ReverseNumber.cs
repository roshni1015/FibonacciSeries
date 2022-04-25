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
            int num, i, reverse = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = num; i != 0; i = i / 10)
            {
                num = i % 10;
                reverse = reverse * 10 + num;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
