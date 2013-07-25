using System;
using System.Text.RegularExpressions;

namespace ProjectI
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            string[] input = new string[cases];
            for (int i = 0; i < cases; i++)
                input[i] = Console.ReadLine();
            int words = int.Parse(Console.ReadLine());
            string[] inputWords = new string[words];
            for (int i = 0; i < words; i++)
            {
                int res = 0;
                inputWords[i] = Console.ReadLine();
                string t = inputWords[i].Substring(0, inputWords[i].Length - 2) + "se";
                Regex r = new Regex(t);
                Regex r1 = new Regex(inputWords[i]);
                for (int a = 0; a < input.Length; a++)
                {
                    res += r.Matches(input[a]).Count;
                    res += r1.Matches(input[a]).Count;
                }
                Console.WriteLine(res.ToString());
            }
            Console.ReadLine();
        }
    }
}
