using System;
using System.Collections.Generic;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            Dictionary<string, int> k = new Dictionary<string, int>();
            List<string> list = new List<string>();
            List<int> listTot = new List<int>();
            int index = 0;
            for (int i = 0; i < cases; i++)
            {
                string temp = Console.ReadLine();
                if (!k.ContainsKey(temp))
                {
                    k.Add(temp, 1);
                    list.Add(temp);
                    listTot.Add(1);
                    Console.WriteLine("OK");
                    continue;
                }
                index = listTot[list.IndexOf(temp)]++;
                Console.WriteLine(temp + index);
            }
            Console.ReadLine();
        }
    }
}
