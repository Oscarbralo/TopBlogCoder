using System;
using System.Collections.Generic;
class Solution
{
    static void Main(String[] args)
    {
        int caseNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < caseNumber; i++)
        {
            long number = long.Parse(Console.ReadLine());
            long last = 1;
            long n = 1;
            while (n < number)
            {
                long temp = last;
                last = n + temp;
                n = temp;
            }
            Console.WriteLine(n == number ? "IsFibo" : "IsNotFibo");
        }
    }
}