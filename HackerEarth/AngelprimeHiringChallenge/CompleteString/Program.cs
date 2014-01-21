using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CompleteString
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string abc = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < cases; i++)
            {
                int[] result = new int[26];
                string text = Console.ReadLine();
                for (int a = 0; a < text.Length; a++)
                {
                    if(result[abc.IndexOf(text[a].ToString())] < 1)
                        result[abc.IndexOf(text[a].ToString())]++;
                }
                int res = result.Sum(x => x);
                if(res == 26)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
