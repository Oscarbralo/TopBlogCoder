using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string cases = "153";
            int res = 0;
            cases.Select(x => x.ToString()).ToList().ForEach(j => res += (int)Math.Pow(double.Parse(j.ToString()), double.Parse(cases.Length.ToString())));
            Console.ReadLine();
        }
    }
}
