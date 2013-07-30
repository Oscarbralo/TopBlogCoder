using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MagicSquare
    {
        int missing(int[] square)
        {
            int min = Math.Min(Math.Min(square[0] + square[1] + square[2], square[3] + square[4] + square[5]), square[6] + square[7] + square[8]);
            return Math.Max(square[0] + square[1] + square[2], square[3] + square[4] + square[5]) - (min + 1);
        }
    }
}
