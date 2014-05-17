using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace LongestLines
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = true;
            int n = 0;
            List<string> list = new List<string>();
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                if (first)
                {
                    first = false;
                    n = int.Parse(line);
                    continue;
                }
                if (null == line)
                    continue;
                list.Add(line);
                //}
            }
            string[] result = list.OrderByDescending(x => x.Length).Take(n).ToArray<string>();
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
            Console.ReadLine();
        }
    }
}
