using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingSort1
{
    class Solution
    {
        static void Main(String[] args)
        {
            int[] res = new int[100];
            int cases = int.Parse(Console.ReadLine());
            string[] input = new string[cases];
            for (int j = 0; j < cases; j++)
            {
                string[] s = Console.ReadLine().Split(' ');
                input[j] = s[0];
            }
            for (int a = 0; a < cases; a++)
                res[int.Parse(input[a])]++;
            int[] result = new int[100];
            result[0] = res[0];
            for (int b = 1; b < 100; b++)
            {
                if (res[b] == 0)
                    result[b] = result[b - 1];
                else
                    result[b] = res[b] + result[b - 1];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
