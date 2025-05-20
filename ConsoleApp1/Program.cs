using ConsoleApp1.NewFolder1;
using ConsoleApp1.NumberExample;
using ConsoleApp1.NumberExample.PrimeNumber;
using ConsoleApp1.StringExample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string currentDir = Directory.GetCurrentDirectory();
            //string projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName+ "\\NewFolder1";

            //Console.WriteLine("Project Directory: " + projectDir);
            //Console.WriteLine("C:\\Users\\VIKASH-PC\\source\\repos\\ConsoleApp1\\ConsoleApp1\\NewFolder1\\");

            //ReverseString.ReverseString1();
            //PalindromeString.CheckPalindromeString();
            //AnagramString.CheckAnagramString();
            //StringCount.CountOfString();
            //ReverseNumber.ReverseNumberWithoutThirdVaiable();
            //ReverseNumber.ReverseNumberWithThirdVaiable();
            //SwapString.SwapStringWithThirdVaiable();
            //SwapString.SwapStringWithoutThirdVaiable();
            //PrimeNumber.CheckPrimeNumber();
            ReverseNumber.ReverseNumber1();
            Console.ReadLine();
        }
    }
}
