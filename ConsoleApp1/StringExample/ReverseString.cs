using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    public class ReverseString
    {
        public static void ReverseString1()
        {
            string s = "Vikash";
            string reverse = "";

            for(int i = s.Length - 1; i >= 0; i--)
            {
                reverse = reverse + s[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
