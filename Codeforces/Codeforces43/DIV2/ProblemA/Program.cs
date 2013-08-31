using System;
using System.Collections.Generic;

namespace A.Football
{
    class Program
    {
        static void Main(string[] args)
        {
            int goals = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            List<int> g = new List<int>();
            for (int i = 0; i < goals; i++)
            {
                string temp = Console.ReadLine();
                if (!list.Contains(temp))
                {
                    list.Add(temp);
                    g.Add(1);
                }
                else
                    g[list.IndexOf(temp)]++;
            }
            if (list.Count == 1)
                Console.WriteLine(list[0]);
            else
            {
                if (g[0] > g[1])
                    Console.WriteLine(list[0]);
                else
                    Console.WriteLine(list[1]);
            }
            Console.ReadLine();
        }
    }
}
