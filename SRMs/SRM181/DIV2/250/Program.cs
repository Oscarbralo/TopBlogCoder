using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            KiloMan a = new KiloMan();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class KiloMan
    {
        public int hitsTaken(int[] pattern, string jumps)
        {
            int result = 0;
            for (int a = 0; a < jumps.Length; a++)
            {
                if (jumps[a] == 'S' && pattern[a] <= 2)
                    result++;
                else if (jumps[a] == 'J' && pattern[a] > 2)
                    result++;
            }
            return result;
        }
    }
}
