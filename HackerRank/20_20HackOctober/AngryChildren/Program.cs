using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AngryChildren
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
                list.Add(int.Parse(Console.ReadLine()));
            int[] temp = list.ToArray();
            Array.Sort(temp);
            int min = 100000000;
            for (int a = 0; a < temp.Length - max; a++)
            {
                int t = temp[a + (max - 1)] - temp[a];
                if (t < min)
                    min = t;
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
