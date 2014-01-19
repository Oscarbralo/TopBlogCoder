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
            IEnumerable<int> coinsUnsorted = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            List<int> list = coinsUnsorted.OrderByDescending(x => x).ToList<int>();
            //if (list.Count == 1)
            //    Console.WriteLine(1);
            //else
            //{
                for (int i = 1; i <= list.Count; i++)
                {
                    int res = (list.Select(x => x).Take(i).Sum() > list.Skip(i).Select(x => x).Sum()) ? i : -1;
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
