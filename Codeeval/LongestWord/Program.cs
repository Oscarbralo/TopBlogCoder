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
                string line = reader.ReadLine();
                string[] temp = line.Split(' ');
                string result = string.Empty;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Length > result.Length)
                    {
                        result = temp[i];
                    }
                }
                Console.WriteLine(result);
            }
    }
}