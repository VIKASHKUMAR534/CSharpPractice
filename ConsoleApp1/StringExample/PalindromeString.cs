using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal class PalindromeString
    {
        public static void CheckPalindromeString()
        {
            string reverse = "";
            string s = "moM";

            for(int i=s.Length-1;i>=0; i--)
            {
                reverse = reverse + s[i];
            }

            if (s.Equals(reverse))
                Console.WriteLine(s + " is a palindrome string");
            else
                Console.WriteLine(s + " is not a palindrome string");
        }
    }
}
