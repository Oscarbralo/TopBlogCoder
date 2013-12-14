using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            TheShuttles x = new TheShuttles();
            int[] a = { 51, 1, 77, 14, 17, 10, 80 };
            Console.WriteLine(x.getLeastCost(a, 32, 40));
            Console.ReadLine();
        }
    }

    public class TheShuttles
    {
        public int getLeastCost(int[] cnt, int baseCost, int seatCost)
        {
            int result = 100000000;
            int max = cnt.Max(x => x);
            int total = cnt.Sum(x => x);
            for (int i = max; i > 0; i--)
            {
                int buses = cnt.Length;
                for (int a = 0; a < cnt.Length; a++)
                {
                    int j = i;
                    while (cnt[a] > j)
                    {
                        buses++;
                        j += i;
                    }
                }
                int temp = (buses * i) * seatCost;
                temp += (buses * baseCost);
                result = Math.Min(result, temp);
            }
            return result;
        }
    }
}
