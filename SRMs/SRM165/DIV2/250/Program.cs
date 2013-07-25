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
            BritishCoins x = new BritishCoins();
            Console.WriteLine(x.coins(0));
            Console.ReadLine();
        }
    }

    public class BritishCoins
    {
        public int[] coins(int pence)
        {
            int[] res = new int[3];
            res[0] = (pence / 12) / 20;
            res[1] = (pence - (res[0] * 12 * 20)) / 12;
            res[2] = (pence % 12) % 20;
            return res;
        }
    }
}
