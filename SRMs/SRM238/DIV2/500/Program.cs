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
            PrintScheduler x = new PrintScheduler();
            string[] a = { "ABCDE" };
            string[] b = { "0 20", "0 21" };
            Console.WriteLine(x.getOutput(a, b));
            Console.ReadLine();
        }
    }

    public class PrintScheduler
    {
        public string getOutput(string[] threads, string[] slices)
        {
            int[] index = new int[threads.Length];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < slices.Length; i++)
            {
                int[] sl = slices[i].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                int indexTemp = index[sl[0]];
                for (int a = index[sl[0]]; a < indexTemp + sl[1]; a++)
                {
                    sb.Append(threads[sl[0]][index[sl[0]]]);
                    index[sl[0]] = (index[sl[0]] + 1) % threads[sl[0]].Length;
                }
            }
            return sb.ToString();
        }
    }
}
