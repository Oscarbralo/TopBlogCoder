using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace SplitTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string[] input = reader.ReadLine().Split(' ');
                    if (input[1].Contains('+'))
                    {
                        string[] indices = input[1].Split('+');
                        long result = long.Parse(string.Join("", input[0].Take(indices[0].Length).Select(x => x.ToString()).ToArray<string>())) + long.Parse(string.Join("", input[0].Skip(indices[0].Length).Take(indices[1].Length).Select(x => x.ToString()).ToArray<string>()));
                        Console.WriteLine(result);
                    }
                    else
                    {
                        string[] indices = input[1].Split('-');
                        long result = long.Parse(string.Join("", input[0].Take(indices[0].Length).Select(x => x.ToString()).ToArray<string>())) - long.Parse(string.Join("", input[0].Skip(indices[0].Length).Take(indices[1].Length).Select(x => x.ToString()).ToArray<string>()));
                        Console.WriteLine(result);
                    }
                }
            Console.ReadLine();
        }
    }
}
