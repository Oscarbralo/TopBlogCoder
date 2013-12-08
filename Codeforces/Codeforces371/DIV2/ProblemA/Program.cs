using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KPeriodicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int resultTemp = 0;
            string[] temp = Console.ReadLine().Split(' ');
            string[] input = Console.ReadLine().Split(' ');
            int ones = input.Select(x => x).Where(x => x == "1").Count();
            int twos = input.Select(x => x).Where(x => x == "2").Count();
            for (int i = 0; i < int.Parse(temp[1]); i++)
            {
                int one = 0;
                int two = 0;
                for (int a = i; a < input.Length; a += int.Parse(temp[1]))
                {
                    if (input[a] == "1")
                        one++;
                    else
                        two++;
                }
                resultTemp += Math.Min(one, two);
            }
            Console.WriteLine(Math.Min(resultTemp, Math.Min(ones, twos)));
            Console.ReadLine();
        }
    }
}
