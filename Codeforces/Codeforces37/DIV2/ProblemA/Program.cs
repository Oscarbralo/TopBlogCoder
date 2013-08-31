using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace A.Towers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            List<string> list = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if(!list.Contains(input[i]))
                    list.Add(input[i]);
            }
            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for (int a = 0; a < input.Length; a++)
                {
                    if (input[a] == list[i])
                        count++;
                }
                if (count > max)
                    max = count;
            }
            Console.WriteLine(max.ToString() + " " + list.Count.ToString());
            Console.ReadLine();
        }
    }
}
