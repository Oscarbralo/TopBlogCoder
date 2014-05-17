using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int n = 1;
            List<int> list = new List<int>();
            while (list.Count < 1000)
            {
                if (p.IsPrime(n))
                    list.Add(n);
                n++;
            }
            Console.WriteLine(list.Sum());
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
