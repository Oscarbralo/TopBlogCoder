using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace CountingPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    int[] input = reader.ReadLine().Split(',').Select(x => int.Parse(x.ToString())).ToArray<int>();
                    int result = 0;
                    for (int i = input[0]; i <= input[1]; i++)
                    {
                        if (p.IsPrime(i))
                            result++;
                    }
                    Console.WriteLine(result);
                }
            Console.ReadLine();
        }

        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int m = (int)Math.Sqrt(n);
            for (int i = 3; i <= m; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
