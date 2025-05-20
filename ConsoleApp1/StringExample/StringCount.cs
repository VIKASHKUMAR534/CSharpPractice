using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal class StringCount
    {
        public static void CountOfString()
        {
            string s = "Find number of words in given string";
            s = s.Trim();
            int count = 0;
            for(int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] ==' ' && char.IsLetter(s[i + 1]))
                    count++;
            }
            Console.WriteLine(++count);
        }
    }
}
