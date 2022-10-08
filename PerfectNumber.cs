using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Problems
{
    public class PerfectNumber
    {

        
        public static void Check()
        {
            int rem, i, sum =0 ;
            Console.Write("\n");
            Console.Write(" program to Print Perfect no:\n");
            Console.Write("----------------------------------------------\n");
  
            Console.WriteLine("enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; (i <= num / 2); i++)
            {
                rem = num % i;
                if (rem == 0)
                {
                    sum += i;
                }

            }
            if (sum == num)
            {
                Console.WriteLine(" \t {0} is a perfect number",num);
            }
            else
            {
                Console.WriteLine(" \t {0} is not a perfect number ",num);
            }
        }
    }

}