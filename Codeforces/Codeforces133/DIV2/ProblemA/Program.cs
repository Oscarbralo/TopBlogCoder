using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HQ9_
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"[HQ9]");
            Console.WriteLine(r.IsMatch(Console.ReadLine()) ? "YES" : "NO");
            Console.ReadLine();
        }
    }
}
