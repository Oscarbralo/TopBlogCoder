using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IEnumerable<int> coinsUnsorted = Console.ReadLine().Split(' ').OrderByDescending(x => int.Parse(x)).Select(x => int.Parse(x)).ToArray<int>();
            for (int i = 1; i <= coinsUnsorted.Count(); i++)
            {
                int res = (coinsUnsorted.Select(x => x).Take(i).Sum() > coinsUnsorted.Skip(i).Select(x => x).Sum()) ? i : -1;
                if (res != -1)
                {
                    Console.WriteLine(res);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
