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
            ClapLight x = new ClapLight();
            int[] a = { 1, 5, 6, 1, 1, 1, 1, 1, 1, 1 };
            Console.WriteLine(x.threshold(a));
            Console.ReadLine();
        }
    }

    public class ClapLight
    {
        public int threshold(int[] background)
        {
            int[] orderedBackground = background.OrderBy(x => x).ToArray<int>();
            int result = orderedBackground[orderedBackground.Length / 2] + 1;
            for (int i = 0; i < background.Length - 2; i++)
            {
                if (background[i] < result && background[i + 1] >= result && background[i + 2] >= result && background[i + 3] < result)
                {
                    i = -1;
                    result++;
                }
            }
            return result;
        }
    }
}
