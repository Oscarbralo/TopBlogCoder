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
            PalindromeMaker x = new PalindromeMaker();
            Console.WriteLine(x.make("ABACABA"));
            Console.ReadLine();
        }
    }

    public class PalindromeMaker
    {
        public string make(string baseString)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] times = new int[26];
            StringBuilder left = new StringBuilder();
            StringBuilder right = new StringBuilder();
            for (int i = 0; i < baseString.Length; i++)
                times[abc.IndexOf(baseString[i])]++;
            for (int i = 0; i < times.Length; i++)
            {
                while (times[i] > 1)
                {
                    left.Append(abc[i]);
                    right.Insert(0, abc[i]);
                    times[i] -= 2;
                }
            }
            if (left.Length > 0)
            {
                for (int i = 0; i < times.Length; i++)
                {
                    if (times[i] > 0)
                    {
                        left.Append(abc[i]);
                        break;
                    }
                }
            }
            return string.Join("", left, right);
        }
    }
}
