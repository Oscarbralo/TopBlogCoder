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
            LevelUp s = new LevelUp();
            int[] a = { 150, 450, 900, 1800 };
            Console.WriteLine(s.toNextLevel(a, 612));
            Console.ReadLine();
        }
    }

    public class LevelUp
    {
        public int toNextLevel(int[] expNeeded, int received)
        {
            int res = received;
            res -= expNeeded[0];
            if (res < 0)
                return Math.Abs(res);
            for (int i = 1; i < expNeeded.Length; i++)
            {
                res -= expNeeded[i] - expNeeded[i - 1];
                if (res < 0)
                {
                    res = Math.Abs(res);
                    break;
                }
            }
            return res;
        }
    }
}
