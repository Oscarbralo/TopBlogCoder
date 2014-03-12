using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace FindAWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "3Kucdq9bfCEgZGF2nwx8UpzQJyHiOm0hoaYP6ST1WM7Nks5XjrR4IltBeDLV vA| 2 26 33 55 34 50 33 61 44 28 46 32 28 30 3 50 34 61 40 7 1 31";
            string[] split = line.Split('|');
            split[1] = split[1].Trim();
            int[] numbers = split[1].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            StringBuilder sb = new StringBuilder();
            numbers.ToList<int>().ForEach(x => sb.Append(split[0][x - 1]));
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
