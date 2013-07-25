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
        }
    }

    public class YahtzeeScore
    {
        public int maxPoints(int[] toss)
        {
            int[] res = new int[6];
            int tot = 0;
            int r = 0;
            for (int i = 0; i < toss.Length; i++)
            {
                res[toss[i] - 1] += toss[i];
                if (res[toss[i] - 1] > tot)
                {
                    tot = res[toss[i] - 1];
                    r = res[toss[i] - 1];
                }
            }
            return r;
        }
    }
}
