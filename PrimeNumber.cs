using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Problems
{
    public class PrimeNumber
    {
        public static void Number()
        {
             
                int n, i, m = 0, flag = 0;
                Console.Write("Enter the Number to check Prime: ");
                n = int.Parse(Console.ReadLine());
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Number {0} is not Prime.",n);
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine("Number  {0} is Prime." , n);
            
        }
    }
    
}
