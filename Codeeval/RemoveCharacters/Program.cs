using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace RemoveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string[] input = reader.ReadLine().Split(',');
                    input[1].Trim().ToList().ForEach(x => input[0] = input[0].Replace(x.ToString(), ""));
                    Console.WriteLine(input[0]);
                }
            Console.ReadLine();
        }
    }
}
