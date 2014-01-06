using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace StringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string[] res = Regex.Replace(text, "[aeiouy]", "").Select(x => x.ToString()).ToArray<string>();
            Console.WriteLine( "." + string.Join(".", res));
            Console.ReadLine();
        }
    }
}
