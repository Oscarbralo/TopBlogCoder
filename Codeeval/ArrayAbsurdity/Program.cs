using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace ArrayAbsurdity
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
            string line = Console.ReadLine();
            //if(line == null)
            //    continue;
            string[] input = line.Split(';');
            int[] n = input[1].Split(',').Select(x => int.Parse(x)).ToArray<int>();
            int[] res = new int[int.Parse(input[0])];
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (res[n[i]] > 1)
                    result = n[i];
                else
                    res[n[i]]++;
            }
            Console.WriteLine(result);
                //}
            Console.ReadLine();
        }
    }
}
