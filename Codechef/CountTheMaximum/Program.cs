using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountTheMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int result = 0;
                int resultTimes = 0;
                int n = int.Parse(Console.ReadLine());
                int[] v = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToArray<int>();
                for (int a = 0; a < v.Length; a++)
                {
                    int count = v.Select(x => x).Where(x => x == v[a]).Count();
                    if (count > resultTimes)
                    {
                        resultTimes = count;
                        result = v[a];
                    }
                }
                Console.WriteLine(result + " " + resultTimes);
            }
            Console.ReadLine();
        }
    }
}
