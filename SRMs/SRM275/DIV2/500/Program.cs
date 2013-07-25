using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Haar1D
    {
        public int[] transform(int[] data, int L)
        {
            int[] trans1 = new int[data.Length];
            int[] trans2 = new int[data.Length];
            int x = 0;
            for (int i = 0; i < data.Length; i += 2)
            {
                trans1[x] = data[i] + data[i + 1];
                x++;
            }
            for (int i = 0; i < data.Length; i += 2)
            {
                trans1[x] = data[i] - data[i + 1];
                x++;
            }
            if (L == 1)
                return trans1;
            int cut = 2;
            while (L > 1)
            {
                x = 0;
                for (int i = 0; i < trans1.Length / cut; i += 2)
                {
                    trans2[x] = trans1[i] + trans1[i + 1];
                    x++;
                }
                for (int i = 0; i < trans1.Length / cut; i += 2)
                {
                    trans2[x] = trans1[i] - trans1[i + 1];
                    x++;
                }
                for (int i = trans1.Length / cut; i < trans1.Length; i++)
                {
                    trans2[x] = trans1[i];
                    x++;
                }
                L--;
                cut *= 2;
                for (int i = 0; i < trans2.Length; i++)
                    trans1[i] = trans2[i];
            }
            return trans2;
        }
    }
}
