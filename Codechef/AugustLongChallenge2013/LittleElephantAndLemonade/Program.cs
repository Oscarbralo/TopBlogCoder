using System;
using System.Collections.Generic;
using System.Linq;

namespace LittleElephantAndLemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                List<List<int>> lists = new List<List<int>>();
                int result = 0;
                string[] inp = Console.ReadLine().Split(' ');
                int rooms = int.Parse(inp[0]);
                int[] input = new int[rooms];
                string[] roomVisits = Console.ReadLine().Split(' ');
                for (int c = 0; c < roomVisits.Length; c++)
                    input[int.Parse(roomVisits[c])]++;
                for (int a = 0; a < rooms; a++)
                {
                    string[] temp = Console.ReadLine().Split(' ');
                    int[] temp1 = new int[temp.Length];
                    for (int d = 0; d < temp.Length; d++)
                        temp1[d] = int.Parse(temp[d]);
                    lists.Add(temp1.ToList());
                    if (lists[a].Count > 0)
                        lists[a].RemoveAt(0);
                    lists[a].Sort();
                    while (lists[a].Count > 0 && input[a] > 0)
                    {
                        if (input[a] > 0)
                        {
                            result += lists[a][lists[a].Count - 1];
                            lists[a].RemoveAt(lists[a].Count - 1);
                            input[a]--;
                        }
                    }
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}

