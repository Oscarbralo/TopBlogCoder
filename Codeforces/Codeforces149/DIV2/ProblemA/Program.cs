using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace BusinessTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int cm = int.Parse(Console.ReadLine());
            int[] months = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Array.Sort(months);
            int result = 0;
            if (months.Sum() < cm)
                Console.WriteLine(-1);
            else
            {
                int x = months.Length - 1;
                while (cm > 0)
                {
                    cm -= months[x];
                    x--;
                    result++;
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
