using System;
using System.Text.RegularExpressions;

namespace ProjectI
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex("^h{1}i{1} ", RegexOptions.IgnoreCase);
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string t = Console.ReadLine();
                if (r.IsMatch(t))
                {
                    if (r.Match(t).Index == 0)
                    {
                        string t2 = t.Substring(3, 1);
                        if (t2 != "d" && t2 != "D")
                            Console.WriteLine(t);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
