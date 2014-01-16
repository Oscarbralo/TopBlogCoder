using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace SoftDrinking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int totalMl = input[1] * input[2];
            int totalLimeSlices = input[3] * input[4];
            int salt = input[5];
            int res = 0;
            while ((totalMl - input[6]) >= 0 && (totalLimeSlices - 1) >= 0 && (salt - input[7]) >= 0)
            {
                res++;
                totalMl -= input[6];
                salt -= input[7];
                totalLimeSlices--;
            }
            Console.WriteLine(res / input[0]);
            Console.ReadLine();
        }
    }
}
