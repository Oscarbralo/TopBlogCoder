using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int one = input.Select(x => x).Where(x => x == 1).Count();
            int two = input.Select(x => x).Where(x => x == 2).Count();
            int three = input.Select(x => x).Where(x => x == 3).Count();
            int four = input.Select(x => x).Where(x => x == 4).Count();
            int result = 0;
            while (three > 0)
            {
                three--;
                if (one > 0)
                    one--;
                result++;
            }
            while (two > 0)
            {
                two--;
                if (one > 0)
                    one -= 2;
                else
                    if (two > 0) two--;
                result++;
            }
            result += four;
            if (one > 0)
            {
                int temp = one % 4;
                result += temp > 0 ? (one / 4) + 1 : one / 4;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
