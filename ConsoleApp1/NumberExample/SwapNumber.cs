using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NumberExample
{
    internal class SwapNumber
    {
        public static void SwapNumberWithoutThirdVaiable()
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("Value of X after swap " + x);
            Console.WriteLine("Value of Y after reverse " + y);

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("Value of X after swap " + x);
            Console.WriteLine("Value of Y after swap " + y);
        }

        public static void SwapNumberWithThirdVaiable()
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("Value of X after swap " + x);
            Console.WriteLine("Value of Y after swap " + y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Value of X after swap " + x);
            Console.WriteLine("Value of Y after swap " + y);
        }
    }
}
