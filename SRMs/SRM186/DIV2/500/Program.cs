using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            WordWrap x = new WordWrap();
            string[] a = {"now is the time for all good men",
 "to come to the aid of their country"};
            Console.WriteLine(x.justify(a, 20));
            Console.ReadLine();
        }
    }

    public class WordWrap
    {
        public string[] justify(string[] lines, int columnWidth)
        {
            string total = string.Join(" ", lines);
            string[] words = total.Split(' ');
            List<string> list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                while (i != words.Length && sb.Length + (words[i].Length + 1) <= columnWidth + 1)
                {
                    sb.Append(words[i] + " ");
                    i++;
                }
                list.Add((sb[sb.ToString().Length - 1] == ' ') ? sb.ToString().Remove(sb.ToString().Length - 1, 1) : sb.ToString());
                i--;
            }
            return list.ToArray();
        }
    }
}

