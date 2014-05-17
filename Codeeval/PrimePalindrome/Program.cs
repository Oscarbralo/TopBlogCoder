using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace PrimePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int n = 999;
            while (!p.IsPrime(n) || !p.IsPalindrome(n))
                n -= 2;
            Console.WriteLine(n);
            Console.ReadLine();
        }

        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            int m = (int)Math.Sqrt(n);
            for (int i = 3; i <= m; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public bool IsPalindrome(int n)
        {
            string nn = n.ToString();
            int j = nn.Length - 1;
            for (int i = 0; i < nn.Length / 2; i++)
            {
                if (nn[i] != nn[j])
                    return false;
            }
            return true;
        }
    }
}
