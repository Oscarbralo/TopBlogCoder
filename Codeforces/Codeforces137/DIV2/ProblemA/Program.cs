using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PostcardAndPhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string Ps = "PPPPP";
            string Cs = "CCCCC";
            string change = "XXXXX";
            int result = 0;
            int count = 5;
            int Xs = 0;
            while (Xs != input.Length)
            {
                Regex rr = new Regex(Cs.Substring(0, count));
                while (rr.IsMatch(input))
                {
                    int index = rr.Match(input).Index;
                    input = input.Insert(index, change.Substring(0, count));
                    input = input.Remove(index + count, count);
                    result++;
                }
                Regex r = new Regex(Ps.Substring(0, count));
                while (r.IsMatch(input))
                {
                    int index = r.Match(input).Index;
                    input = input.Insert(index, change.Substring(0, count));
                    input = input.Remove(index + count, count);
                    result++;
                }
                count--;
                Xs = input.Select(x => x).Where(x => x == 'X').Count();
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
