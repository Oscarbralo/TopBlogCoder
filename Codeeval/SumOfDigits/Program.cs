using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine().Select(x => int.Parse(x.ToString())).Sum());
                }
            Console.ReadLine();
        }
    }
}
