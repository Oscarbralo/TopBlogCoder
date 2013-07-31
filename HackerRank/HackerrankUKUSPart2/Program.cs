using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int cases = int.Parse(Console.ReadLine());
        List<string> input = new List<string>();
        for (int i = 0; i < cases; i++)
            input.Add(Console.ReadLine());
        int wordsNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < wordsNumber; i++)
        {
            int result = 0;
            string word1 = Console.ReadLine();
            string word2 = word1.Replace("our", "or");
            for (int a = 0; a < input.Count; a++)
            {
                string[] temp = input[a].Split(' ');
                result += temp.Select(x => x).Where(x => x == word1).Count();
                result += temp.Select(x => x).Where(x => x == word2).Count();
            }
            Console.WriteLine(result);
        }
        Console.ReadLine();
    }
}
