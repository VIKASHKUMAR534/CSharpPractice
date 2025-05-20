using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringExample
{
    internal class SwapString
    {
        public static void SwapStringWithoutThirdVaiable()
        {
            string s1 = "Vikash";
            string s2 = "Kumar";

            Console.WriteLine("Value of X after swap " + s1);
            Console.WriteLine("Value of Y after swap " + s2);

            s1 = s1 + s2; //VikashKumar
            s2 = s1.Substring(0, s1.Length - s2.Length); //
            s1 = s1.Substring(s2.Length);

            Console.WriteLine("Value of X after swap " + s1);
            Console.WriteLine("Value of Y after swap " + s2);
        }

        public static void SwapStringWithThirdVaiable()
        {
            string s1 = "Vikash";
            string s2 = "Kumar";

            Console.WriteLine("Value of X after swap " + s1);
            Console.WriteLine("Value of Y after swap " + s2);
            string temp;
            temp = s1;
            s1 = s2;
            s2 = temp;
            Console.WriteLine("Value of X after swap " + s1);
            Console.WriteLine("Value of Y after swap " + s2);
        }
    }
}
