using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Problems
{
    public class CouponNumber
    {
        public static void Generate ()
        {




            int distinct = 0, count = 0, coupon_no;
            Console.Write("Enter the number of distinct coupons:");
            coupon_no = Convert.ToInt32(Console.ReadLine());
            bool[] is_collected = new bool[coupon_no];
            while (distinct < coupon_no)
            {
                Random random = new Random();
                int option = random.Next(1, 1000);
                int new_coupon = (int)(random.NextDouble() * coupon_no);
                count++;
                if (!is_collected[new_coupon])
                {
                    distinct++;
                    is_collected[new_coupon] = true;
                }
            }

            Console.WriteLine("Total random number of  distinct coupon : " + count);

        }
    }
}
