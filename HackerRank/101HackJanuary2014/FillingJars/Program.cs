using System;
using System.Linq;

namespace FillingJars
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray<double>();
            double res = 0;
            for (int a = 0; a < input[1]; a++)
            {
                double[] temp = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray<double>();
                res += (((temp[1] - temp[0]) + 1) * temp[2]);
            }
            Console.WriteLine(Math.Floor(res / input[0]));
            Console.ReadLine();
        }
    }
}
