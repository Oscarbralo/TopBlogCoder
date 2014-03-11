using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                int result = line.Length;
                for (int i = line.Length; i > 0; i--)
                {
                    string temp = line.Substring(0, i);
                    Regex r = new Regex(temp);
                    if (r.Matches(line).Count * temp.Length == line.Length)
                    {
                        result = Math.Min(result, i);
                    }
                }
                Console.WriteLine(result);
            }
    }
}