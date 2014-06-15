using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ValeraAndAntiquesItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            List<int> results = new List<int>();
            for (int i = 0; i < cases[0]; i++)
            {
                int[] prices = Console.ReadLine().Split(' ').Skip(1).Select(x => int.Parse(x)).ToArray<int>();
                if (prices.Any(x => cases[1] > x))
                    results.Add(i + 1);
            }
            Console.WriteLine(results.Count);
            Console.WriteLine(string.Join(" ", results.Select(x => x.ToString()).ToArray<string>()));
            Console.ReadLine();
        }
    }
}
