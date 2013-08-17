using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace A.Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int boys = int.Parse(input[0]);
            string[] temp = Console.ReadLine().Split(' ');
            List<int> t1 = new List<int>();
            for (int i = 0; i < temp.Length; i++)
                t1.Add(int.Parse(temp[i]));
            int[] p = t1.ToArray();
            Array.Sort(p);
            int minDiff = 10000000;
            if (boys == temp.Length)
                Console.WriteLine(p[p.Length - 1] - p[0]);
            else
            {
                for (int i = 0; i < p.Length - 1; i++)
                {
                    for (int a = i + 1; a < p.Length; a++)
                    {
                        int t = 0;
                        for (int b = 0; b < p.Length; b++)
                        {
                            if (p[b] >= p[i] && p[b] <= p[a])
                                t++;
                            if (t == boys)
                            {
                                if (p[a] - p[i] < minDiff)
                                {
                                    minDiff = p[a] - p[i];
                                }
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine(minDiff);
            }
            Console.ReadLine();
        }
    }
}
