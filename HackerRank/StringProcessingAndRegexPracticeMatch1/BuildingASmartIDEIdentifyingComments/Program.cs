using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuildingASmartIDEIdentifyingComment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            bool x = false;
            Regex r = new Regex(@"//");
            Regex r1 = new Regex(@"beginline");
            Regex r2 = new Regex(@"endline");
            for (int a = 0; a < 200; a++)
            {
                string line = Console.ReadLine();
                if (line == null)
                    break;
                line = line.Replace(@"*/", "endline");
                line = line.Replace(@"/*", "beginline");
                if (r.IsMatch(line))
                {
                    result.Add(line.Substring(r.Match(line).Index, line.Length - r.Match(line).Index));
                    continue;
                }
                if (r1.IsMatch(line))
                {
                    x = true;
                    if (r2.IsMatch(line))
                    {
                        line = line.Replace("endline", @"*/");
                        x = false;
                    }
                    line = line.Replace("beginline", @"/*");
                    result.Add(line);
                    continue;
                }
                if (x)
                {
                    if (r2.IsMatch(line))
                    {
                        line = line.Replace("endline", @"*/");
                        result.Add(line.Substring(0, line.Length - r2.Match(line).Index));
                        x = false;
                    }
                    else
                        result.Add(line);
                }
            }
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine(result[i]);
            Console.ReadLine();
        }
    }
}

