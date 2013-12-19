using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n <= 10 || n > 21)
                Console.WriteLine(0);
            else if (n < 20)
                Console.WriteLine(4);
            else if (n == 20)
                Console.WriteLine(15);
            else
                Console.WriteLine(19);
        }
    }
}
