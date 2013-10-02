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
            int cases = int.Parse(Console.ReadLine());
            int[] res = new int[cases];
            string s = Console.ReadLine();
            string[] input = s.Split(' ');
            for (int a = 0; a < cases; a++)
                res[a] = int.Parse(input[a]);
            Array.Sort(res);
            Console.WriteLine(string.Join(" ", res));
        }
    }
}