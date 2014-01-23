using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace WizardsAndDemostration
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray<double>();
            double temp = (Math.Ceiling(((input[2] * input[0]) / 100)) - input[1]);
            Console.WriteLine(temp < 0 ? 0 : temp);
            Console.ReadLine();
        }
    }
}
