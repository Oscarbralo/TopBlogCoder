using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class TypoCoderDiv2
    {
        public int count(int[] rating)
        {
            int current = 500;
            bool low = true;
            int res = 0;
            for (int i = 0; i < rating.Length; i++)
            {
                current = rating[i];
                if (current >= 1200 && low == true)
                {
                    res++;
                    low = false;
                }
                else if (current < 1200 && low == false)
                {
                    res++;
                    low = true;
                }
            }
            return res;
        }
    }
}
