using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator a = new SimpleCalculator();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class SimpleCalculator
    {
        public int calculate(string input)
        {
            Regex r = new Regex(@"\D");
            int result = 0;
            char temp = input[r.Match(input).Index];
            string[] splits = input.Split(temp);
            if (temp == '+')
                result = int.Parse(splits[0]) + int.Parse(splits[1]);
            if (temp == '-')
                result = int.Parse(splits[0]) - int.Parse(splits[1]);
            if (temp == '*')
                result = int.Parse(splits[0]) * int.Parse(splits[1]);
            if (temp == '/')
                result = int.Parse(splits[0]) / int.Parse(splits[1]);
            return result;
        }
    }
}
