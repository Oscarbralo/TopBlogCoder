using System;

namespace LifeWithoutZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            int a1 = int.Parse(a.ToString().Replace("0", ""));
            int b1 = int.Parse(b.ToString().Replace("0", ""));
            int c1 = a1 + b1;
            if(c.ToString().Replace("0", "") == c1.ToString())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
