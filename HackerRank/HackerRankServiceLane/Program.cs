using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        int[] road = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        for (int i = 0; i < input[1]; i++)
        {
            int[] query = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Console.WriteLine(road.Skip(query[0]).Take((query[1] - query[0]) + 1).ToArray<int>().Min());
        }
        Console.ReadLine();
    }
}