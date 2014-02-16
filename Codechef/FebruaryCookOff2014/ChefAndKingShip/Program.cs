using System;
using System.Linq;

namespace ChefAndKingShip
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int cities = int.Parse(Console.ReadLine());
                int[] n = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                long min = n.Min();
                long total = n.Sum(x => x * min) - (min * min);
                Console.WriteLine(total);
            }
            Console.ReadLine();
        }
    }
}
