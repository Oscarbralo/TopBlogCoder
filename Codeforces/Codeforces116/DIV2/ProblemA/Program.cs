using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int peopleMax = 0;
            int max = 0;
            for (int i = 0; i < cases; i++)
            {
                int[] temp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                peopleMax -= temp[0];
                peopleMax += temp[1];
                max = Math.Max(peopleMax, max);
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
