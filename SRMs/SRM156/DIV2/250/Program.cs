using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskSpace x = new DiskSpace();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class DiskSpace
    {
        public int minDrives(int[] used, int[] total)
        {
            Array.Sort(total);
            int res = 0;
            int tot = 0;
            for (int i = 0; i < used.Length; i++)
                tot += used[i];
            int x = total.Length - 1;
            while (tot > 0)
            {
                tot -= total[x];
                x--;
                res++;
            }
            return res;
        }
    }
}
