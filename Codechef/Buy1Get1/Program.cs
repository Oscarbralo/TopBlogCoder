using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Buy1Get1
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int result = 0;
                int[] times = new int[52];
                Console.ReadLine().Select(x => x.ToString()).ToList<string>().ForEach(x => times[abc.IndexOf(x)] += 1);
                times.ToList().ForEach(x => result += (x + 1) / 2);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
