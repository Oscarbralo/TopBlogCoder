using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _450
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrows a = new Arrows();
            Console.WriteLine(a.longestArrow("<--->--==>"));
            Console.ReadLine();
        }
    }

    public class Arrows
    {
        public int longestArrow(string s)
        {
            Regex r1 = new Regex(@"[<]{1}[-]{0,}");
            Regex r2 = new Regex(@"[-]{0,}[>]{1}");
            Regex r3 = new Regex(@"[<]{1}[=]{0,}");
            Regex r4 = new Regex(@"[=]{0,}[>]{1}");
            int max = 0;
            foreach (Match m in r1.Matches(s))
            {
                if (m.Value.Length > max)
                    max = m.Value.Length;
            }
            foreach (Match m in r2.Matches(s))
            {
                if (m.Value.Length > max)
                    max = m.Value.Length;
            }
            foreach (Match m in r3.Matches(s))
            {
                if (m.Value.Length > max)
                    max = m.Value.Length;
            }
            foreach (Match m in r4.Matches(s))
            {
                if (m.Value.Length > max)
                    max = m.Value.Length;
            }
            if (max == 0)
                return -1;
            return max;
        }
    }
}