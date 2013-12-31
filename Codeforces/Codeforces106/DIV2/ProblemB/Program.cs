using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChoosingLaptop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            bool[] possible = new bool[cases];
            string[] input = new string[cases];
            int[] prices = new int[cases];
            for (int i = 0; i < cases; i++)
            {
                input[i] = Console.ReadLine();
                possible[i] = true;
            }
            for (int i = 0; i < input.Length; i++)
            {
                int[] temp = input[i].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                prices[i] = temp[3];
                for (int a = 0; a < input.Length; a++)
                {
                    if (a == i)
                        continue;
                    int[] temp2 = input[a].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                    if (temp[0] < temp2[0] && temp[1] < temp2[1] && temp[2] < temp2[2])
                        possible[i] = false;
                }
            }
            int cheaper = 0;
            int min = 10000000;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min && possible[i] == true)
                {
                    cheaper = i;
                    min = prices[i];
                }
            }
            Console.WriteLine(cheaper);
            Console.ReadLine();
        }
    }
}
