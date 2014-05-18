using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.IO;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
                    string line = Console.ReadLine();
                    //if (string.IsNullOrEmpty(line))
                    //    continue;
                    string abc = "abcdefghijklmnopqrstuvwxyz";
                    int[] indices = new int[26];
                    bool finish = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (abc.Contains(line[i].ToString().ToLower()))
                            indices[abc.IndexOf(line[i].ToString().ToLower())]++;
                        if (indices.All(x => x > 0))
                        {
                            finish = true;
                            break;
                        }
                    }
                    if (finish)
                        Console.WriteLine("NULL");
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < indices.Length; i++)
                        {
                            if (indices[i] == 0)
                                sb.Append(abc[i].ToString());
                        }
                        Console.WriteLine(sb.ToString());
                    }
                //}
            Console.ReadLine();
        }
    }
}
