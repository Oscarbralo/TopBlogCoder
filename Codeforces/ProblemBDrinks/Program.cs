using System;
using System.Linq;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string res = (Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray<double>().Sum() / n).ToString("##.############").Replace(",", ".");
            Console.WriteLine(string.IsNullOrEmpty(res) ? "0" : res);
            Console.ReadLine();
        }
    }
}
