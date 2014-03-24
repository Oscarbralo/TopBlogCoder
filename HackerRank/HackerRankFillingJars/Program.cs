using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        long[] temp = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray<long>();
        long res = 0;
        for (int i = 0; i < temp[1]; i++)
        {
            long[] input = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray<long>();
            res += ((input[1] + 1) - input[0]) * input[2];
        }
        double result = res / temp[0];
        res = (long)Math.Floor(result);
        Console.WriteLine(res);
    }
}