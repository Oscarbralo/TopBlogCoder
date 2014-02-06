using System;
using System.Linq;

namespace BearAndRapsberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[] prices = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int result = 0;
            for (int i = 0; i < prices.Length - 1; i++)
                result = Math.Max(result, prices[i] - (prices[i + 1] + cases[1]));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
