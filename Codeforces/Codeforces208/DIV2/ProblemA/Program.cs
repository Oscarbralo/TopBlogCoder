using System;
using System.Collections.Generic;
using System.Linq;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            List<int> result = new List<int>();
            if (input[1] == 2)
                Console.WriteLine(1);
            else
            {
                int diffTemp = input[1] - (input[0] * 2);
                for (int i = 0; i < input[0]; i++)
                    result.Add(2);
                int j = 0;
                while (diffTemp > 0 || result.Where(x => x == 3).Count() == result.Count)
                {
                    if (j == result.Count)
                        j = 0;
                    result[j]++;
                    j++;
                    diffTemp--;
                }
                Console.WriteLine(result.Where(x => x == 2).Count());
            }
            Console.ReadLine();
        }
    }
}