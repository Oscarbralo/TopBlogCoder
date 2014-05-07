using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace GemStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<int[]> list = new List<int[]>();
            GetArrayOfLetters get = new GetArrayOfLetters();
            for (int i = 0; i < cases; i++)
            {
                string text = Console.ReadLine();
                list.Add(get.GetLetters(text));
            }
            int result = 0;
            for (int i = 0; i < list[0].Length; i++)
            {
                if (list.All(x => x[i] > 0))
                    result++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class GetArrayOfLetters
    {
        public int[] GetLetters(string text)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int[] letters = new int[26];
            text.Select(x => x.ToString()).ToList().ForEach(x => letters[abc.IndexOf(x)]++);
            return letters;
        }
    }
}
