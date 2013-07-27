using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            MicrowaveSelling a = new MicrowaveSelling();
            Console.WriteLine(a.mostAttractivePrice(460,680));
            Console.ReadLine();
        }
    }

    public class MicrowaveSelling
    {
        public int mostAttractivePrice(int minPrice, int maxPrice)
        {
            int res = 0;
            int nines = 0;
            for (int i = minPrice; i <= maxPrice; i++)
            {
                int nine = howManyNines(i);
                if (nine >= nines)
                {
                    if (i > res)
                    {
                        res = i;
                        nines = nine;
                    }
                }
            }
            return res;
        }

        public int howManyNines(int number)
        {
            int n = 0;
            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                if (number.ToString()[i] == '9')
                    n++;
                else
                    break;
            }
            return n;
        }
    }
}
