using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Find_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string check = "abcdefghijklmnopqrstuvwxyz1234567890_";
            string[] sentences = new string[cases];
            for (int i = 0; i < cases; i++)
                sentences[i] = "-" + Console.ReadLine() + "-";
            int words = int.Parse(Console.ReadLine());
            for (int i = 0; i < words; i++)
            {
                int res = 0;
                string temp = Console.ReadLine();
                Regex r = new Regex(temp);
                for (int a = 0; a < sentences.Length; a++)
                {
                    foreach (Match m in r.Matches(sentences[a]))
                    {
                        if ((!check.Contains(sentences[a][m.Index - 1].ToString())) && (!check.Contains(sentences[a][m.Index + temp.Length].ToString())))
                            res++;
                    }
                }
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
