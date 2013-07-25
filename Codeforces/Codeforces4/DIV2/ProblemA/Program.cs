using System;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            if (weight == 2 || weight % 2 == 1)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
            Console.ReadLine();
        }
    }
}
