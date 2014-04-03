using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Carvans
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int result = 1;
                int numberCars = int.Parse(Console.ReadLine());
                int[] speeds = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                if (speeds.Length == 1)
                    Console.WriteLine(result);
                else
                {
                    for (int a = 1; a < speeds.Length; a++)
                    {
                        if (speeds[a] > speeds[a - 1])
                            speeds[a] = speeds[a - 1];
                        else
                            result++;
                    }
                    Console.WriteLine(result);
                }
            }
            Console.ReadLine();
        }
    }
}
