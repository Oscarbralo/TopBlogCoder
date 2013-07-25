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
            BigBurger x = new BigBurger();
            int[] a = { 2, 10, 12 };
            int[] b = { 15, 1, 15 };
            Console.WriteLine(x.maxWait(a,b));
            Console.ReadLine();
        }
    }

    public class BigBurger
    {
        public int maxWait(int[] arrival, int[] service)
        {
            int max = 0;
            int lastEnd = arrival[0] + service[0];
            for (int i = 1; i < arrival.Length; i++)
            {
                if (arrival[i] <= lastEnd)
                {
                    if (lastEnd - arrival[i] > max)
                        max = lastEnd - arrival[i];
                    lastEnd += service[i];
                }
                else
                    lastEnd = arrival[i] + service[i];
            }
            return max;
        }
    }
}
