using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NumberExample
{
    internal class ReverseNumber
    {
        public static void ReverseNumber1()
        {
            int num = 123;
            int sum = 0;
            while(num > 0)
            {
                int rem = num % 10;
                sum = (sum * 10) + rem;
                num /= 10;
            }
            Console.WriteLine("Reverse of given number is " + sum);

        }
    }
}
