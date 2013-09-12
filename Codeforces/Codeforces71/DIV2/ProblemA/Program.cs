using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A.Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string input = Console.ReadLine();
                if (input.Length > 10)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(input[0]);
                    sb.Append(input.Length - 2);
                    sb.Append(input[input.Length - 1]);
                    Console.WriteLine(sb.ToString());
                }
                else
                    Console.WriteLine(input);
            }
            Console.ReadLine();
        }
    }
}
