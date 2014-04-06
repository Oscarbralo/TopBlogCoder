using System;
using System.Linq;

namespace RacingHorses
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                long[] horses = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).OrderBy(x => x).ToArray<long>();
                long min = long.MaxValue;
                for (int a = 0; a < horses.Length - 1; a++)
                {
                        min = Math.Min(horses[a - 1] - horses[a], min);
                }
                Console.WriteLine(min);
            }
            Console.ReadLine();
        }
    }
}
