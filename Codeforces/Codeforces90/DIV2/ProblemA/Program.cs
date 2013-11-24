using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cableway
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int totalRed = (int.Parse(input[0]) + 1) / 2 - 1;
            int totalGreen = (int.Parse(input[1]) + 1) / 2 - 1;
            int totalBlue = (int.Parse(input[2]) + 1) / 2 - 1;
            int total = 30;
            if (totalBlue > totalGreen && totalBlue > totalRed)
                total += (3 * totalBlue) + 2;
            else if (totalGreen > totalBlue && totalGreen > totalRed)
                total += (3 * totalGreen) + 1;
            else if (totalRed > totalBlue && totalRed > totalGreen)
                total += (3 * totalRed);
            else
            {
                int max = Math.Max(totalRed, Math.Max(totalBlue, totalGreen));
                total += (3 * max);
                if (max == totalBlue)
                    total += 2;
                else if (max == totalGreen)
                    total++;
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
