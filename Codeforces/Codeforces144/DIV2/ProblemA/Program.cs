using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ArrivalOfGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSoldiers = int.Parse(Console.ReadLine());
            int[] soldiers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int max = 0;
            int maxIndex = 0;
            int min = 1000000;
            int minIndex = 0;
            for (int i = 0; i < soldiers.Length; i++)
            {
                if (soldiers[i] > max)
                {
                    max = soldiers[i];
                    maxIndex = i;
                }
                if (soldiers[i] <= min)
                {
                    min = soldiers[i];
                    minIndex = i;
                }
            }
            int res = maxIndex;
            res += (maxIndex > minIndex) ? (soldiers.Length - 1) - (minIndex + 1) : (soldiers.Length - 1) - minIndex;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
