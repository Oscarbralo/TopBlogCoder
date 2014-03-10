using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                int[] array = reader.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                List<string> list = new List<string>();
                for (int i = 1; i <= array[2]; i++)
                {
                    if (i % array[0] == 0 && i % array[1] == 0)
                        list.Add("FB");
                    else if (i % array[0] == 0)
                        list.Add("F");
                    else if (i % array[1] == 0)
                        list.Add("B");
                    else
                        list.Add(i.ToString());
                }
                Console.WriteLine(string.Join(" ", list.ToArray<string>()));
            }
        }
    }
}