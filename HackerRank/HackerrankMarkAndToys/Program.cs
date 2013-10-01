using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MarkAndToys
{
    class Solution
    {
        static void Main(String[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] numbers = Console.ReadLine().Split(' ');
            int[] prices = new int[numbers.Length];
            for (int a = 0; a < numbers.Length; a++)
                prices[a] = int.Parse(numbers[a]);
            Array.Sort(prices);
            int money = int.Parse(input[1]);
            int result = 0;
            for (int b = 0; b < prices.Length; b++)
            {
                if (money == 0)
                    break;
                if (money < 0)
                {
                    result--;
                    break;
                }
                money -= prices[b];
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
