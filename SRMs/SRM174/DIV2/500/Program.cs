using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayOdds x = new BirthdayOdds();
            Console.WriteLine(x.minPeople(99, 2));
            Console.ReadLine();
        }
    }

    public class BirthdayOdds
    {
        public int minPeople(int minOdds, int daysInYear)
        {
            double percen = 100.0 - (double)minOdds;
            int res = 0;
            for (int i = daysInYear; i > 0; i--)
            {
                double temp = 100.0;
                for (int a = daysInYear; a >= i; a--)
                    temp *= (double)a / (double)daysInYear;
                if (temp <= percen)
                {
                    res = daysInYear - i + 1;
                    break;
                }
            }
            if (res == 0)
                return daysInYear + 1;
            return res;
        }
    }
}
