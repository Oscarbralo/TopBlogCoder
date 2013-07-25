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
            StairClimb x = new StairClimb();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class StairClimb
    {
        public int stridesTaken(int[] flights, int stairsPerStride)
        {
            int res = -2;
            for (int i = 0; i < flights.Length; i++)
            {
                while (flights[i] > 0)
                {
                    flights[i] -= stairsPerStride;
                    res++;
                }
                res += 2;
            }
            return res;
        }
    }
}
