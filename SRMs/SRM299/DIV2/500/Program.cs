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
            Projections x = new Projections();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class Projections
    {
        public int[] count(string front, string right)
        {
            int colums = front.Count(x => x == 'x');
            int rows = right.Count(x => x == 'x');
            int[] result = { Math.Max(colums, rows), colums * rows};
            return result;
        }
    }
}
