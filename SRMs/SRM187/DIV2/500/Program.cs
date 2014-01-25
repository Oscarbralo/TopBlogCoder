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
            DNASingleMatcher x = new DNASingleMatcher();
            Console.WriteLine(x.longestMatch("A", "A"));
            Console.ReadLine();
        }
    }

    public class DNASingleMatcher
    {
        public int longestMatch(string sequence1, string sequence2)
        {
            int result = 0;
            int tempResult = 0;
            if (sequence1.Length > sequence2.Length)
            {
                tempResult = checkSubstrings(sequence2, sequence1);
            }
            else
            {
                tempResult = checkSubstrings(sequence1, sequence2);
            }
            return Math.Max(result, tempResult);
        }

        public int checkSubstrings(string text1, string text2)
        {
            int result = -1;
            for (int i = 0; i <= text1.Length - 1; i++)
            {
                for (int a = text1.Length; a > i; a--)
                {
                    string temp = text1.Substring(i, a - i);
                    if (text2.Contains(temp))
                    {
                        result = Math.Max(result, a - i);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
