using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class CouponNumbers
    {
        public void couponnumbers()
        {
            Console.WriteLine("Enter number of coupons");
            int number = Convert.ToInt32(Console.ReadLine());
            string coupons = string.Empty;
            while (number > 0)
            {
                int random = new Random().Next(1, 123);
                coupons += (char)random;
                number--;
            }
            Console.Write("Your coupon number is " + coupons);
        }
    }
}
