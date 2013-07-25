using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfitCalculator p = new ProfitCalculator();
            string[] a = { "012.99 008.73", "099.99 050.00", "123.45 101.07" };
            Console.WriteLine(p.percent(a));
            Console.ReadLine();
        }
    }

    public class ProfitCalculator
    {
        public int percent(string[] items)
        {
            double cost = 0.0;
            double price = 0.0;
            double res = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string[] temp1 = items[i].Split(' ');
                price += double.Parse(temp1[0]) / 100;
                cost += double.Parse(temp1[1]) / 100;
            }
            double temp = price - cost;
            res = (temp * 100.0) / price;
            return (int)res;
        }
    }
}
