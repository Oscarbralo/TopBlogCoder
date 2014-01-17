using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace NextRound
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Console.WriteLine(input.Select(x => x).Where(x => x >= input[cases[1] - 1]).Count());
            Console.ReadLine();
        }
    }
}
