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
            Hyphenated x = new Hyphenated();
            string[] a = { "  now is the ex-", "ample.  " };
            Console.WriteLine(x.avgLength(a));
            Console.ReadLine();
        }
    }

    public class Hyphenated
    {
        public double avgLength(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                for (int a = 0; a < lines[i].Length - 1; a++)
                {
                    if (lines[i][a] == '-' && lines[i][a + 1] != '-')
                    {
                        lines[i] = lines[i].Insert(a, " ");
                        lines[i] = lines[i].Remove(a + 1, 1);
                    }
                }
                if (lines[i][lines[i].Length - 1] != '-')
                    lines[i] += " ";
            }
            string res = "." + string.Join("", lines) + ".";
            for (int i = 1; i < res.Length - 1; i++)
            {
                if (res[i] == '-' && res[i + 1] == '-')
                {
                    if (res[i - 1] == ' ')
                    {
                        res = res.Remove(i + 1, 1);
                        i--;
                    }
                    else
                    {
                        res = res.Insert(i, " ");
                        res = res.Remove(i + 1, 1);
                    }
                }
                else if (res[i] == '-' && res[i + 1] != '-')
                {
                    res = res.Remove(i, 1);
                }
            }
            res = res.Replace(".", " ");
            char[] charSeparator = { ' ' };
            string[] temp = res.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);
            double result = (double)string.Join("", temp).Length / (double)temp.Length;
            return result;
        }
    }
}
