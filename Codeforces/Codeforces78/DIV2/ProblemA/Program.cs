using System;
using System.Text.RegularExpressions;

namespace Haiku
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"[aeiou]");
            int[] haiku = new int[3];
            for (int i = 0; i < 3; i++)
                haiku[i] = r.Matches(Console.ReadLine()).Count;
            if(haiku[0] == 5 && haiku[1] == 7 && haiku[2] == 5)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
