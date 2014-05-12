using System;
using System.Collections.Generic;
using System.Linq;
namespace StackOverFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            long[] n = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            if (input[1] == 0)
                Console.WriteLine(string.Join(" ", n.Select(x => x.ToString()).ToArray()));
            else
            {
                long[] newN = new long[n.Length];
                long max = n.Max();
                for (int i = 0; i < n.Length; i++)
                    n[i] = max - n[i];
                long max2 = n.Max();
                for (int i = 0; i < n.Length; i++)
                    newN[i] = max2 - n[i];
                if (input[1] % 2 == 0)
                    Console.WriteLine(string.Join(" ", newN.Select(x => x.ToString()).ToArray()));
                else
                    Console.WriteLine(string.Join(" ", n.Select(x => x.ToString()).ToArray()));
            }
            Console.ReadLine();
        }
    }
}