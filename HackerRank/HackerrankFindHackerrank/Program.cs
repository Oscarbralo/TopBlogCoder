using System;
using System.Text.RegularExpressions;

namespace ProjectI
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string pattern = "hackerrank";
            Regex r = new Regex(pattern);
            for (int i = 0; i < cases; i++)
            {
                string input = Console.ReadLine();
                int index = r.Match(input).Index;
                if (index == 0 && input.Length > pattern.Length)
                    Console.WriteLine("1");
                else if (index != 0 && index == input.Length - pattern.Length)
                    Console.WriteLine("2");
                else if (input == pattern)
                    Console.WriteLine("0");
                else
                    Console.WriteLine("-1");
            }
            Console.ReadLine();
        }
    }
}
