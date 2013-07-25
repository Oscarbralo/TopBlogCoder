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
            Inventory x = new Inventory();
            int[] a = { 3179, 502, 2481, 8901 };
            int[] b = { 26, 27, 28, 29 };
            Console.WriteLine(x.monthlyOrder(a,b));
            Console.ReadLine();
        }
    }

    public class Inventory
    {
        public int monthlyOrder(int[] sales, int[] daysAvailable)
        {
            double total = 0.0;
            int zeros = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                if (daysAvailable[i] == 0) 
                {
                    zeros++;
                    continue;
                }
                if (daysAvailable[i] == 30)
                    total += (double)sales[i];
                else
                    total += (30.0 * (double)sales[i]) / (double)daysAvailable[i];
            }
            int res = ((total / (daysAvailable.Length - zeros)).ToString().Contains(",")) ? (int)(Math.Ceiling(total / (daysAvailable.Length - zeros))): (int)(total / (daysAvailable.Length - zeros));
            return res;
        }
    }
}
