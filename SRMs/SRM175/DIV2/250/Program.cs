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
            ClockWalk x = new ClockWalk();
            Console.WriteLine(x.finalPosition("tttttttt"));
            Console.ReadLine();
        }
    }

    public class ClockWalk
    {
        public int finalPosition(string flips)
        {
            int res = 0;
            for (int i = 0; i < flips.Length; i++)
            {
                if (flips[i].ToString() == "h")
                {
                    res += (i + 1);
                    while (res > 12)
                        res -= 12;
                }
                else
                {
                    res -= (i + 1);
                    while (res < 0)
                        res += 12;
                }
                if (res == 0)
                    res = 12;
            }
            return res;
        }
    }
}
