using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChoosingTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[] people = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Where(x => x <= 5 - cases[1]).ToArray<int>();
            Console.WriteLine(people.Length / 3);
            Console.ReadLine();
        }
    }
}
