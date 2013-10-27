using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int res = 0;
                string[] temp = Console.ReadLine().Split(' ');
                int candies = int.Parse(temp[0]) / int.Parse(temp[1]);
                res += candies;
                int wrapper = res;
                while (wrapper >= int.Parse(temp[2]))
                {
                    int extra = wrapper / int.Parse(temp[2]);
                    wrapper %= int.Parse(temp[2]);
                    res += extra;
                    wrapper += extra;
                }
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
