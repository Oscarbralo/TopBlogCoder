using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace LowestUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    List<int> numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
                    int[] n = new int[10];
                    for (int i = 0; i < numbers.Count; i++)
                        n[numbers[i]]++;
                    int result = int.MaxValue;
                    int max = int.MaxValue;
                    for (int i = n.Length - 1; i > 0; i--)
                    {
                        if (n[i] == 1 && n[i] < max)
                        {
                            max = i;
                            result = numbers.IndexOf(max) + 1;
                        }
                    }
                    Console.WriteLine(result == int.MaxValue ? 0 : result);
                }
                Console.ReadLine();
        }
    }
}
