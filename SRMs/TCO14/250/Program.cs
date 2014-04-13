using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            EllysSortingTrimmer x = new EllysSortingTrimmer();
            Console.WriteLine(x.getMin("TOPCODER", 3));
            Console.ReadLine();
        }
    }

    public class EllysSortingTrimmer
    {
        public string getMin(string S, int L)
        {
            List<string> word = S.Select(x => x.ToString()).ToList<string>();
            int i = 0;
            while (word.Count - i > L)
            {
                int j = word.Count - L;
                string sorted = string.Join("", word.Skip(word.Count - L).Take(L).OrderBy(x => x).ToArray<string>());
                S = S.Insert(word.Count - L - i, sorted);
                S = S.Remove(word.Count - L - i + sorted.Length, sorted.Length);
                for (int a = 0; a < sorted.Length; a++)
                {
                    word[j] = sorted[a].ToString();
                    j++;
                }
                word = word.Take(word.Count - 1).ToList();
            }
            return string.Join("", word.OrderBy(x => x).ToArray<string>());
        }
    }
}
