using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ILoveUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int[] points = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            List<int> past = new List<int>();
            past.Add(points[0]);
            int result = 0;
            for (int i = 1; i < points.Length; i++)
            {
                if (past.Select(x => x).Where(x => x > points[i]).Count() == past.Count)
                    result++;
                else if (past.Select(x => x).Where(x => x < points[i]).Count() == past.Count)
                    result++;
                past.Add(points[i]);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
