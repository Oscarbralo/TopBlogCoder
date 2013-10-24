using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DetectingValidLatitudeAndLongitudePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string temp = Console.ReadLine();
                temp = temp.Replace(")", "");
                temp = temp.Replace("(", "");
                temp = temp.Replace("+", "");
                temp = temp.Replace("-", "");
                string[] numbers = temp.Split(',');
                if (numbers[0][numbers[0].Length - 1] == '.' || numbers[1][numbers[1].Length - 1] == '.')
                {
                    Console.WriteLine("Invalid");
                    continue;
                }
                string[] xNumber = new string[2];
                string[] yNumber = new string[2];
                int x = 0;
                int y = 0;
                if (numbers[0].Contains("."))
                {
                    xNumber = numbers[0].Split('.');
                    if (int.Parse(xNumber[0]) == 90 && int.Parse(xNumber[1]) > 0 || xNumber[0].Length > 2)
                    {
                        Console.WriteLine("Invalid");
                        continue;
                    }
                    x = int.Parse(xNumber[0]);
                }
                else
                    x = int.Parse(numbers[0]);
                if (numbers[1].Contains("."))
                {
                    yNumber = numbers[1].Split('.');
                    if (int.Parse(yNumber[0]) == 180 && int.Parse(yNumber[1]) > 0 || yNumber[0].Length > 4)
                    {
                        Console.WriteLine("Invalid");
                        continue;
                    }
                    y = int.Parse(yNumber[0]);
                }
                else
                    y = int.Parse(numbers[1]);
                if (x <= 90 && y <= 180)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
    }
}