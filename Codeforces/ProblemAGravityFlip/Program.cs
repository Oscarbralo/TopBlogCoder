using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace GravityFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(x => int.Parse(x)).
                OrderBy(x => x).Select(x => x.ToString()).ToArray<string>()));
            Console.ReadLine();
        }
    }
}
