using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace VanyaAndCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int sum = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Sum();
            int total = Math.Abs(sum * -1);
            Console.WriteLine(total % cases[1] > 0 ? total / cases[1] + 1 : total / cases[1]);
            Console.ReadLine();
        }
    }
}
