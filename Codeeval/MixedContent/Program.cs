using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Regex regex = new Regex(@"[0-9]+");
                List<string> words = new List<string>();
                List<string> numbers = new List<string>();
                for (int i = 0; i < line.Length; i++)
                {
                    if (regex.IsMatch(line[i]))
                        numbers.Add(line[i]);
                    else
                        words.Add(line[i]);
                }
                string left = string.Join(",", words.ToArray<string>());
                string right = string.Join(",", numbers.ToArray<string>());
                if (string.IsNullOrEmpty(left))
                    Console.WriteLine(right);
                else if (string.IsNullOrEmpty(right))
                    Console.WriteLine(left);
                else
                    Console.WriteLine(left + "|" + right);
            }
    }
}