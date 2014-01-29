using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            FanFailure x = new FanFailure();
            int[] a = { 676, 11, 223, 413, 823, 122, 547, 187, 28 };
            Console.WriteLine(x.getRange(a, 1000));
            Console.ReadLine();
        }
    }

    public class FanFailure
    {
        public int[] getRange(int[] capacities, int minCooling)
        {
            int[] result = { 0, 0 };
            Array.Sort(capacities);
            List<int> list = capacities.Select(x => x).OrderByDescending(x => x).ToList<int>();
            int totalCount = list.Sum();
            int temp = 0;
            result[0] = capacities.TakeWhile(x => (totalCount - (temp += x)) >= minCooling).Count();
            temp = 0;
            result[1] = list.TakeWhile(x => (totalCount - (temp += x)) >= minCooling).Count();
            return result;
        }
    }
}
