using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace A_DieRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cases = Console.ReadLine().Split(' ');
            int max = Math.Max(int.Parse(cases[0]), int.Parse(cases[1]));
            int wins = 0;
            while (max <= 6)
            {
                max++;
                wins++;
            }
            switch (wins)
            {
                case 1:
                    Console.WriteLine("1/6");
                    break;
                case 2:
                    Console.WriteLine("1/3");
                    break;
                case 3:
                    Console.WriteLine("1/2");
                    break;
                case 4:
                    Console.WriteLine("2/3");
                    break;
                case 5:
                    Console.WriteLine("5/6");
                    break;
                case 6:
                    Console.WriteLine("1/1");
                    break;
            }
            Console.ReadLine();
        }
    }
}
