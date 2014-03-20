using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                bool finish = false;
                for (int i = 0; i < line[0].Length; i++)
                {
                    string temp = string.Join("", line[0].Skip(i).Take(line[0].Length - i).Select(x => x.ToString()).ToArray<string>()) + string.Join("", line[0].Take(i).Select(x => x.ToString()).ToArray<string>());
                    if (temp == line[1])
                    {
                        finish = true;
                        break;
                    }
                }
                Console.WriteLine(finish ? "True" : "False");
            }
    }
}