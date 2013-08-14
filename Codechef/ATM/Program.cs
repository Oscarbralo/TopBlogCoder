using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cases = Console.ReadLine().Split(' ');
            double cash = double.Parse(cases[0]) + 0.5;
            if (int.Parse(cases[0]) % 5 == 0)
            {
                double temp = double.Parse(cases[1]);
                if (cash > (double.Parse(cases[1]) / 100))
                    Console.WriteLine(cases[1]);
                else
                    Console.WriteLine((double.Parse(cases[1]) / 100) - cash);

            }
            else
                Console.WriteLine(cases[1]);
            Console.ReadLine();
        }
    }
}
