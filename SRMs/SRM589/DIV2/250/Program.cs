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
            GooseTattarrattatDiv2 x = new GooseTattarrattatDiv2();
            Console.WriteLine(x.getmin("t"));
            Console.ReadLine();
        }
    }

    public class GooseTattarrattatDiv2
    {
        public int getmin(string S)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int[] times = new int[abc.Length];
            foreach (char s in S)
                times[abc.IndexOf(s.ToString())]++;
            int result = 0;
            int max = 0;
            int index = 0;
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] > max)
                {
                    max = times[i];
                    index = i;
                }
            }
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] > 0 && i != index)
                    result += times[i];
            }
            return result;
        }
    }
}
