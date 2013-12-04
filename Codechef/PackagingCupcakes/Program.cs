using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackagingCupcakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int res = 0;
                int n = int.Parse(Console.ReadLine());
                if (n == 2)
                    res = 2;
                else
                    res = n - (n % (( n / 2) + 1));
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
