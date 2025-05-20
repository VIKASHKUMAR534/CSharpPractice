using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal class AnagramString
    {
        public static void CheckAnagramString()
        {
            string s1 = "geeks";
            string s2 = "kseeg1";
            bool flag = false;

            if(s1.Length != s2.Length)
            {
                Console.WriteLine(s1 + " is not a anagram string");
                flag = true;
            }
            else
            {
                char[] c1 = s1.ToCharArray();
                char[] c2 = s2.ToCharArray();

                Array.Sort(c1);
                Array.Sort(c2);

                for(int i=0;i<c1.Length; i++)
                {
                    if (c1[i] != c2[i])
                    {
                        Console.WriteLine(s1 + " is not a anagram string");
                        flag = true;
                        break;
                    }
                }
            }

            if (!flag)
                Console.WriteLine(s1 + " is a anagram string");
        }
    }
}
