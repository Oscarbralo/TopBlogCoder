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
            LCMRange x = new LCMRange();
            Console.WriteLine(x.lcm(1,5));
            Console.ReadLine();
        }
    }

    public class LCMRange
    {
        public int lcm(int first, int last)
        {
            int res = last;
            for (int i = first; i <= last; i++)
            {
                if (res % i == 0)
                {
                    continue;
                }
                else
                {
                    res++;
                    i = first - 1;
                }
            }
            return res;
        }
    }
}
