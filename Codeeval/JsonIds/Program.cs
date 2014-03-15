using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JsonIds
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "{'menu'";
            Regex r = new Regex(@"(Label )\d+");
            int result = 0;
            foreach (Match m in r.Matches(line))
                result += int.Parse(m.Value.Split(' ')[1]);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
