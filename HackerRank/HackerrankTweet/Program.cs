using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank_Tweets
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            Regex r = new Regex("hackerrank", RegexOptions.IgnoreCase);
            int res = 0;
            for (int i = 0; i < cases; i++)
            {
                if (r.IsMatch(Console.ReadLine()))
                    res++;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
