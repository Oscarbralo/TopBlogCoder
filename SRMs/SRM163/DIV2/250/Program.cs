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
            Inchworm x = new Inchworm();
            Console.WriteLine(x.lunchtime(11,2,4));
            Console.ReadLine();
        }
    }

    public class Inchworm
    {
        public int lunchtime(int branch, int rest, int leaf)
        {
            int res = 1;
            int begin = 0;
            while (begin < branch)
            {
                begin += leaf;
                if (begin % rest == 0)
                {
                    if (begin > branch)
                        break;
                    res++;
                }
            }
            return res;
        }
    }
}
