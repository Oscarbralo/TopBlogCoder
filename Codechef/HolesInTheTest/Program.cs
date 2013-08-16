using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HolesInTheText
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            Regex r = new Regex("[ADOPQR]");
            Regex r1 = new Regex("[B]");
            for (int i = 0; i < cases; i++)
            {
                int res = 0;
                string input = Console.ReadLine();
                res += r.Matches(input).Count;
                res += (r1.Matches(input).Count * 2);
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
