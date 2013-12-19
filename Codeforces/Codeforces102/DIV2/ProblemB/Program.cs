using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int temp = 11;
            string n = Console.ReadLine();
            while (temp.ToString().Length != 1 && n.Length > 1)
            {
                temp = n.Sum(x => int.Parse(x.ToString()));
                n = temp.ToString();
                result++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
