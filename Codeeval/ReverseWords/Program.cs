using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello World";
            Console.WriteLine(string.Join(" ", line.Split(' ').Reverse().ToArray<string>()));
            Console.ReadLine();
        }
    }
}
