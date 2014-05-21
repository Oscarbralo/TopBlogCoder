using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace ReverseGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
                    string[] input = Console.ReadLine().Split(';');
            int k = int.Parse(input[1]);
                    int[] numbers = input[0].Split(',').Select(x => int.Parse(x)).ToArray<int>();
                    int resto = numbers.Length % k;
                    int skip = 0;
                    int next = -1;
                    for (int i = 0; i < (numbers.Length - resto) / k; i++)
                    {
                        int[] n = numbers.Skip(skip).Take(k).Reverse().ToArray<int>();
                        for (int a = 0; a < n.Length; a++)
                        {
                            numbers[++next] = n[a];
                        }
                        skip += k;
                    }
                    Console.WriteLine(string.Join(",", numbers));
                //}
            Console.ReadLine();
        }
    }
}
