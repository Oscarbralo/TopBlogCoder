using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            string three = "555";
            string five = "33333";
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                int res = n / 3;
                while (res > 0)
                {
                    sb.Append(three);
                    res--;
                }
                int resFinal = n % 3;
                while (resFinal != 0 && sb.Length > 0)
                {
                        sb = sb.Remove(0, 3);
                        resFinal += 3;
                        if (resFinal % 5 == 0)
                            break;
                }
                if (resFinal % 5 == 0)
                {
                    while (resFinal > 0)
                    {
                        sb.Insert(sb.Length, five);
                        resFinal -= 5;
                    }
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            Console.ReadLine();
        }
    }
}
