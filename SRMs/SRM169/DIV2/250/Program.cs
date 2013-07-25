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
            Swimmers s = new Swimmers();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class Swimmers
    {
        public int[] getSwimTimes(int[] distances, int[] speeds, int current)
        {
            double[] temp1 = new double[distances.Length];
            int[] res = new int[distances.Length];
            for (int i = 0; i < speeds.Length; i++)
            {
                if (distances[i] == 0)
                    temp1[i] = 0;
                else if (speeds[i] - current < 1)
                    temp1[i] = -1.0;
                else
                {
                    temp1[i] = (double)distances[i] / ((double)speeds[i] + (double)current);
                    temp1[i] += (double)distances[i] / ((double)speeds[i] - (double)current);
                }
            }
            for (int i = 0; i < temp1.Length; i++)
                res[i] = (int)temp1[i];
            return res;
        }
    }
}
