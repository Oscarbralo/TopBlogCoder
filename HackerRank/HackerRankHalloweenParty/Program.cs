using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int cases = int.Parse(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            int n = int.Parse(Console.ReadLine());
            long a1 = n / 2;
            long a2 = (n + 1) / 2;
            long temp = (long)Math.Pow(n / 2, 2);
            long result = n % 2 == 0 ? temp : a2 * a1;
            Console.WriteLine(result);
        }
    }
}