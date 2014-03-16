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
            PrimeStatistics x = new PrimeStatistics();
            Console.WriteLine(x.mostCommonRemainder(3, 14, 5));
            Console.ReadLine();
        }
    }

    public class PrimeStatistics
    {
        public int mostCommonRemainder(int lowerBound, int upperBound, int modulo)
        {
            List<int> list = GetPrimes(lowerBound, upperBound).Select(x => x %= modulo).ToList();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!dic.ContainsKey(list[i]))
                    dic.Add(list[i], 1);
                else
                    dic[list[i]] += 1;
            }
            return dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).FirstOrDefault();
        }

        public List<int> GetPrimes(int lowerBound, int upperDound)
        {
            List<int> list = new List<int>();
            for (int i = lowerBound; i <= upperDound; i++)
            {
                if (IsPrime(i))
                    list.Add(i);
            }
            return list;
        }

        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int m = (int)Math.Sqrt(n);

            for (int i = 3; i <= m; i += 2)
                if (n % i == 0) return false;
            return true;
        }
    }
}
