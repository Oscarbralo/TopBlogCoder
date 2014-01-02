using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NearlyLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex r = new Regex("[47]");
            int n = r.Matches(input).Count;
            Console.WriteLine((n == 4 || n == 7) ? "YES" : "NO");
            Console.ReadLine();
        }
    }
}
