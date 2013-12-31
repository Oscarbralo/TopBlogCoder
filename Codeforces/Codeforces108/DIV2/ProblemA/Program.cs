using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PalindromicTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            int[] t = time.Split(':').Select(x => int.Parse(x)).ToArray<int>();
            string hours = t[0].ToString();
            string minutes = t[1].ToString();
            hours = (t[0].ToString().Length == 1) ? "0" + t[0].ToString() : t[0].ToString();
            minutes = (t[1].ToString().Length == 1) ? "0" + t[1].ToString() : t[1].ToString();
            bool first = false;
            while (hours[0] != minutes[1] || hours[1] != minutes[0] || first == false)
            {
                t[1]++;
                if (t[1] == 60)
                {
                    t[1] = 0;
                    t[0] = (t[0] + 1) % 24;
                }
                hours = (t[0].ToString().Length == 1) ? "0" + t[0].ToString() : t[0].ToString();
                minutes = (t[1].ToString().Length == 1) ? "0" + t[1].ToString() : t[1].ToString();
                first = true;
            }
            Console.WriteLine(hours + ":" + minutes);
            Console.ReadLine();
        }
    }
}
