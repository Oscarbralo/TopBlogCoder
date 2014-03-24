using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int caseNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < caseNumber; i++)
        {
            long cases = long.Parse(Console.ReadLine());
            List<long> list = new List<long>();
            list.Add(1);
            long n = list[list.Count - 1];
            while (n < cases)
            {
                long temp = list[list.Count - 1];
                list.Add(n + temp);
                n = temp;
            }
            Console.WriteLine(n == cases ? "IsFibo" : "IsNotFibo");
        }
    }
}