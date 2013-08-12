using System;
namespace SplittingCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (ulong.Parse(input[1]) == 0)
                    Console.WriteLine(input[1] + " " + input[0]);
                else
                    Console.WriteLine((ulong.Parse(input[0]) / ulong.Parse(input[1])) + " " + (ulong.Parse(input[0]) % ulong.Parse(input[1])));
            }
            Console.ReadLine();
        }
    }
}