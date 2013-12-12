using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuttingRecipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                bool finish = false;
                int[] input = Console.ReadLine().Split(' ').Skip(1).Select(x => int.Parse(x)).ToArray<int>();
                int[] res = new int[input.Length];
                for (int a = input.Max(x => x); a > 0; a--)
                {
                    if (input.All(x => x % a == 0))
                    {
                        finish = true;
                        for (int b = 0; b < input.Length; b++)
                            res[b] = input[b] / a;
                    }
                    if (finish)
                        break;
                }
                string[] inputFinal = input.Select(x => x.ToString()).ToArray<string>();
                string[] resFinal = res.Select(x => x.ToString()).ToArray<string>();
                if(finish)
                    Console.WriteLine(string.Join(" ", resFinal));
                else
                    Console.WriteLine(string.Join(" ", inputFinal));
            }
            Console.ReadLine();
        }
    }
}
