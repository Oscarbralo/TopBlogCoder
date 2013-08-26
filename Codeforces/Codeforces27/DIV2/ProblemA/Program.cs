using System;
using System.Collections.Generic;

namespace A.Next_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];
            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(input[i]);
            Array.Sort(num);
            int count = 1;
            int res = 0;
            while (num[res] == count)
            {
                res++;
                count++;
                if (res == num.Length)
                    break;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
