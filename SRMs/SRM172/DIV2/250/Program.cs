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
            SkipRope x = new SkipRope();
            int[] a = { 119, 139, 152, 139, 133, 152, 98, 174, 81, 150, 128, 103, 78, 131, 111, 160, 114, 137, 114, 101, 87, 84, 94, 165, 87 };
            Console.WriteLine(x.partners(a,175));
            Console.ReadLine();
        }
    }

    public class SkipRope
    {
        public int[] partners(int[] candidates, int height)
        {
            int[] res = new int[2];
            int[] cand = new int[candidates.Length + 1];
            for (int i = 0; i < candidates.Length; i++)
            {
                cand[i] = candidates[i] - height;
            }
            cand[cand.Length - 1] = height - height;
            Array.Sort(cand);
            int x = 0;
            for (int i = cand.Length - 2; i > 0; i--)
            {
                if (cand[i] == 0)
                {
                    if (cand[i + 1] <= Math.Abs(cand[i - 1]))
                    {
                        res[x] = cand[i + 1] + height;
                        cand[i + 1] = 10000;
                        Array.Sort(cand);
                        i = cand.Length - 1;
                        x++;
                    }
                    else
                    {
                        res[x] = cand[i - 1] + height;
                        cand[i - 1] = -10000;
                        Array.Sort(cand);
                        i = cand.Length - 1;
                        x++;
                    }
                }
                if (x == 2)
                    break;
            }
            if (cand[cand.Length - 1] == 0)
            {
                res[0] = cand[cand.Length - 3] + height;
                res[1] = cand[cand.Length - 2] + height;
            }
            else if (cand[0] == 0)
            {
                res[0] = cand[1] + height;
                res[1] = cand[2] + height;
            }
            Array.Sort(res);
            return res;
        }
    }
}
