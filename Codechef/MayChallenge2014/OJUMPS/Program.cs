using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace ChefJumping
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long x = a % 6;
            if (x == 0 || x == 1 || x == 3)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadLine();
        }
    }
}
