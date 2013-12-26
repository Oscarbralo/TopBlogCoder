using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayOdds x = new BirthdayOdds();
            Console.WriteLine(x.minPeople(75, 5));
            Console.ReadLine();
        }
    }

    public class BirthdayOdds
    {
        public int minPeople(int minOdds, int daysInYear)
        {
            int result = 0;
            double days = (double)daysInYear;
            for (int i = 1; i < 1000; i++)
            {
                double res = 1.0;
                double x = (double)daysInYear;
                for (int a = 0; a < i; a++)
                {
                    res *= x / days;
                    x--;
                }
                res *= 100.0;
                double temp = 100.0 - res;
                if (temp > minOdds)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
