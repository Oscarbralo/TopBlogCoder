using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            FoxAndSightseeing x = new FoxAndSightseeing();
            int[] a = { 1, 4, -1, 3 };
            Console.WriteLine(x.getMin(a));
            Console.ReadLine();
        }
    }

    public class FoxAndSightseeing
    {
        public int getMin(int[] position)
        {
            int res = 1000000000;
            int[] t = new int[position.Length - 1];
            for (int i = 1; i < position.Length - 1; i++)
            {
                int x = 0;
                for (int b = 0; b < position.Length; b++)
                {
                    if (b != i)
                    {
                        t[x] = position[b];
                        x++;
                    }
                }
                int temp = 0;
                for (int a = 0; a < t.Length - 1; a++)
                    temp += Math.Abs(t[a] - t[a + 1]);
                res = Math.Min(res, temp);
            }
            return res;
        }
    }
}
