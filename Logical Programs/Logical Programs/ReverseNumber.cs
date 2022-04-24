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
           
            int n1 = 0, n2 = 1, n3, j, num;
            Console.Write("Enter the Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); 
            for (j = 2; j < num; ++j)     
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
        }
    }
}
