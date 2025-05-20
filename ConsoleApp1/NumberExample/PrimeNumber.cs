using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NumberExample.PrimeNumber
{
    internal class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            bool flag = false;
            int num = 19;
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not a prime number");
                flag = true;
            }
            else
            {
                for(int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(num + " is not a prime number");
                        flag = true;
                        break;
                    }

                }
            }
            if(!flag)
                Console.WriteLine(num + " is a prime number");
        }
    }
}
