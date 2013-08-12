using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] t = Console.ReadLine().Split(' ');
            int[] toys = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
                toys[i] = int.Parse(t[i]);
            Array.Sort(toys);
            int result = 0;
            long money = long.Parse(input[1]);
            int toy = 0;
            while (money > 0 && money - toys[toy] >= 0)
            {
                money -= toys[toy];
                result++;
                toy++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
