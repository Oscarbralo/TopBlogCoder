using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace AmusingJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string letters = Console.ReadLine();
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] lettersNames = new int[26];
            foreach (char n in name1)
                lettersNames[abc.IndexOf(n.ToString())]++;
            foreach (char n in name2)
                lettersNames[abc.IndexOf(n.ToString())]++;
            foreach (char l in letters)
                lettersNames[abc.IndexOf(l.ToString())]--;
            int sum = lettersNames.Select(x => Math.Abs(x)).Sum();
            Console.WriteLine(sum == 0 ? "YES" : "NO");
            Console.ReadLine();
        }
    }
}
