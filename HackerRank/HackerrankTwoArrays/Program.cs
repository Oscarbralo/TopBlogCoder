using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoArrays
{
    class Solution
    {
        static void Main(String[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int a = 0; a < cases; a++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int max = int.Parse(input[1]);
                string[] inp1 = Console.ReadLine().Split(' ');
                string[] inp2 = Console.ReadLine().Split(' ');
                int[] input1 = new int[inp1.Length];
                int[] input2 = new int[inp2.Length];
                for (int j = 0; j < inp1.Length; j++)
                {
                    input1[j] = int.Parse(inp1[j]);
                    input2[j] = int.Parse(inp2[j]);
                }
                int last = input2.Length - 1;
                bool finish = true;
                Array.Sort(input1);
                Array.Sort(input2);
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] + input2[last] < max)
                    {
                        finish = false;
                        break;
                    }
                    last--;
                }
                if (finish)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
