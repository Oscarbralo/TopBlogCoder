using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            string[] highway = Console.ReadLine().Split(' ');
            int cases = int.Parse(temp[1]);
            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int min = 10000000;
                for (int a = int.Parse(input[0]); a <= int.Parse(input[1]); a++)
                    min = Math.Min(min, int.Parse(highway[a]));
                Console.WriteLine(min);
            }
            Console.ReadLine();
        }
    }
}
