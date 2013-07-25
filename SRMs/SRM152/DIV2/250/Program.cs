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
            FixedPointTheorem x = new FixedPointTheorem();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class FixedPointTheorem
    {
        public double cycleRange(double R)
        {
            double temp = 0.25;
            for (int i = 0; i < 200000; i++)
            {
                temp = R * temp * (1 - temp);
            }
            double min = 20.0;
            double max = 0;
            for (int i = 0; i < 1000; i++)
            {
                temp = R * temp * (1 - temp);
                if (temp < min)
                    min = temp;
                if (temp > max)
                    max = temp;
            }
            return max - min;
        }
    }
}
