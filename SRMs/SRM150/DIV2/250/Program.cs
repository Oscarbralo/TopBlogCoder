using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            WidgetRepairs s = new WidgetRepairs();
            int[] a = { 0, 0, 0 };
            Console.WriteLine(s.days(a, 10));
            Console.ReadLine();
        }
    }

    public class WidgetRepairs
    {
        public int days(int[] arrivals, int numPerDay)
        {
            for (int i = 0; i < arrivals.Length - 1; i++)
            {
                if (arrivals[i] == 0)
                {
                    continue;
                }
                arrivals[i] -= numPerDay;
                if (arrivals[i] > 0)
                    arrivals[i + 1] += arrivals[i];
                res++;
            }
            while (arrivals[arrivals.Length - 1] > 0)
            {
                arrivals[arrivals.Length - 1] -= numPerDay;
                res++;
            }
            return res;
        }
    }
}
