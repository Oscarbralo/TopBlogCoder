using System;
using System.Collections.Generic;
using System.Linq;

namespace LineToCashiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cashes = int.Parse(Console.ReadLine());
            int[] numberItems = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int min = int.MaxValue;
            for (int i = 0; i < cashes; i++)
            {
                List<int> items = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList<int>();
                int result = 0;
                items.ForEach(x => result += x * 5);
                result += items.Count * 15;
                min = Math.Min(result, min);
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
