using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace A.Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = int.Parse(input[1]);
            string[] nums = Console.ReadLine().Split(' ');
            int[] sequence = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                sequence[i] = int.Parse(nums[i]);
            int result = 0;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    int dif = sequence[i - 1] - sequence[i];
                    if(dif == 0)
                    {
                        result++;
                        sequence[i] += (sum);
                        continue;
                    }
                    int times = dif / sum;
                    sequence[i] += (sum * (times + 1));
                    result += times + 1;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
