using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaguePicks x = new LeaguePicks();
            Console.WriteLine(x.returnPicks(5, 10, 1));
            Console.ReadLine();
        }
    }

    public class LeaguePicks
    {
        public int[] returnPicks(int position, int friends, int picks)
        {
            List<int> list = new List<int>();
            if (picks < position)
                return new int[0];
            list.Add(position);
            int down = ((position - 1) * 2) + 1;
            int top = ((friends - position) * 2) + 1;
            int last = position;
            bool x = true;
            int temp = 0;
            for (int i = 0; i < 40; i++)
            {
                if (x == true)
                {
                    temp = last + top;
                    if (temp > picks)
                        break;
                    list.Add(temp);
                    x = false;
                    last = temp;
                }
                else
                {
                    temp = last + down;
                    if (temp > picks)
                        break;
                    list.Add(temp);
                    x = true;
                    last = temp;
                }
            }
            return list.ToArray();
        }
    }
}
