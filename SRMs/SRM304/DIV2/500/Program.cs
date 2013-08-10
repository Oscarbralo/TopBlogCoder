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
            MovingAvg x = new MovingAvg();
            double[] a = { 3, 8, 9, 15 };
            Console.WriteLine(x.difference(2,a));
            Console.ReadLine();
        }
    }

    public class MovingAvg
    {
        public double difference(int k, double[] data)
        {
            List<double> list = new List<double>();
            if (k == data.Length)
                return 0.0;
            for (int a = 0; a <= data.Length - k; a++)
            {
                double temp = 0.0;
                for (int b = a; b < a + k; b++)
                    temp += data[b];
                list.Add(temp / k);
            }
            double[] res = list.ToArray();
            Array.Sort(res);
            return res[res.Length - 1] - res[0];
        }
    }
}
