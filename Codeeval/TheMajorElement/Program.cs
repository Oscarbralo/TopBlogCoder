using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace TheMajorElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
            int[] input = Console.ReadLine().Split(',').Select(x => int.Parse(x.ToString())).ToArray<int>();
            int[] temp = new int[101];
            for (int i = 0; i < input.Length; i++)
                temp[input[i]]++;
            int result = -1;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > input.Length / 2)
                {
                    result = i;
                    break;
                }
            }
            Console.WriteLine(result == -1 ? "None" : result.ToString());
            //    }
            Console.ReadLine();
        }
    }
}
