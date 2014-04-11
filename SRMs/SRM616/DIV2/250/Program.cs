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
            WakingUpEasy x = new WakingUpEasy();
            int[] a = {42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37,
  92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36,
  95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69};
            Console.WriteLine(x.countAlarms(a, 9999));
            Console.ReadLine();
        }
    }

    public class WakingUpEasy
    {
        public int countAlarms(int[] volume, int S)
        {
            int result = 0;
            for (int i = 0; i < volume.Length; i++)
            {
                if (S > 0)
                {
                    S -= volume[i];
                    result++;
                }
            }
            return result;
        }
    }
}
