using System;
using System.Text.RegularExpressions;

namespace A.Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex lower = new Regex("[a-z]");
            Regex upper = new Regex("[A-Z]");
            int low = lower.Matches(s).Count;
            int up = upper.Matches(s).Count;
            if(up > low)
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
            Console.ReadLine();
        }
    }
}
