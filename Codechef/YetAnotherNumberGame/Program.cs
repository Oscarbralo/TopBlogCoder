using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace YetAnotherNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n % 2 == 1 ? "BOB" : "ALICE");
            }
            Console.ReadLine();
        }
    }
}
