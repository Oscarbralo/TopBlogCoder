using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
        //    using (StreamReader reader = File.OpenText(args[0]))
        //        while (!reader.EndOfStream)
        //        {
                    int n = int.Parse(Console.ReadLine());
                    List<long> fib = new List<long>();
                    fib.Add(0);
                    fib.Add(1);
                    for (int i = 0; i < n; i++)
                        fib.Add(fib[fib.Count - 1] + fib[fib.Count - 2]);
                //    Console.WriteLine(fib[n]);
                //}
        }
    }
}
