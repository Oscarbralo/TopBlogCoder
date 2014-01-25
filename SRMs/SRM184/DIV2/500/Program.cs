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
            BagOfHolding x = new BagOfHolding();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(x.oddsReachable(a, 4));
            Console.ReadLine();
        }
    }

    public class BagOfHolding
    {
        public double oddsReachable(int[] sizes, int item)
	    {
            return 1 / double.Parse(sizes.Select(x => x).Where(x => x >= sizes[item]).ToArray<int>().Length.ToString());
	    }
    }
}
