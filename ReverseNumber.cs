using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Problems
{
    
        public static class ReverseNumber
        {
            public static void Check()
            {
                int n, rev = 0, rem;
                Console.WriteLine("Enter Number");
            Console.WriteLine( "\n");
                n = Convert.ToInt32(Console.ReadLine());

                while (n != 0)
                {
                    rem = n % 10;
                    rev = rev * 10 + rem;
                    n /= 10;
                }
                Console.WriteLine("Reversed Number is : {0}", rev);

            }
        }
}
