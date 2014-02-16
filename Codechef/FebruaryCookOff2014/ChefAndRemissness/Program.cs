using System;
using System.Linq;

namespace ChefAndRemissness
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                Console.WriteLine(Math.Max(input[0], input[1]) + " " + input.Sum());
            }
            Console.ReadLine();
        }
    }
}
