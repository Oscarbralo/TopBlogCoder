using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IdentifyingComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Regex r = new Regex(@"//");
            bool loop = false;
            while ((s = Console.ReadLine()) != null)
            {
                string temp = "";
                if (r.IsMatch(s))
                {
                    temp = s.Substring(r.Match(s).Index, s.Length - r.Match(s).Index);
                    Console.WriteLine(temp);
                }
                else if (s.Contains("*/"))
                {
                    Console.WriteLine(s);
                    loop = false;
                }
                else if (loop)
                {
                    Console.WriteLine(s);
                }
                else if (s.Contains("/*"))
                {
                    Console.WriteLine(s);
                    loop = true;
                }
            }
            Console.ReadLine();
        }
    }
}
