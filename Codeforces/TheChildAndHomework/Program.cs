using System;
using System.Collections.Generic;
using System.Linq;

namespace TheChildAndHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] res = {"A", "B", "C", "D" };
            string[] input = new string[4];
            for (int i = 0; i < 4; i++)
                input[i] = Console.ReadLine().Split('.')[1];
            List<int> lengths = new List<int>();
            for (int i = 0; i < input.Length; i++)
                lengths.Add(input[i].Length);
            List<string> choices = new List<string>();
            for (int i = 0; i < lengths.Count; i++)
            {
                int len = lengths[0];
                if (lengths.Skip(1).Take(3).All(x => len >= x * 2) || lengths.Skip(1).Take(3).All(x => len <= x / 2))
                    choices.Add(res[i]);
                lengths.Add(lengths[0]);
                lengths.RemoveAt(0);
            }
            Console.WriteLine(choices.Count != 1 ? "C" : choices[0]);
            Console.ReadLine();
        }
    }
}
