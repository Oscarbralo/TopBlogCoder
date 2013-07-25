using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Valid_PAN_format
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            Regex r = new Regex("[A-Z]{5}[0-9]{4}[A-Z]{1}");
            for (int a = 0; a < cases; a++)
            {
                if (r.IsMatch(Console.ReadLine()))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
