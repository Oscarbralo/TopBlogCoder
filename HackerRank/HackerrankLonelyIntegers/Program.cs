using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LonelyInteger
{
    class Solution
    {
        static void Main(String[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] temp = new int[input.Length];
            for (int a = 0; a < temp.Length; a++)
                temp[a] = int.Parse(input[a]);
            List<int> list = new List<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                if (!list.Contains(temp[i]))
                    list.Add(temp[i]);
                else
                    list.RemoveAt(list.IndexOf(temp[i]));
            }
            Console.WriteLine(list[0]);
        }
    }
}
