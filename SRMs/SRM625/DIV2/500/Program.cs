using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            IncrementingSequence x = new IncrementingSequence();
            int[] a = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 };
            Console.WriteLine(x.canItBeDone(2, a));
            Console.ReadLine();
        }
    }

    public class IncrementingSequence
    {
        public string canItBeDone(int k, int[] A)
        {
            A = A.OrderBy(x => x).ToArray<int>();
            int[] temp = Enumerable.Range(1, A.Length).ToArray<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < temp[i])
                {
                    while (A[i] < temp[i])
                    {
                        A[i] += k;
                    }
                    if (A[i] > temp[i])
                    {
                        A = A.OrderBy(x => x).ToArray<int>();
                        i--;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != temp[i])
                    return "IMPOSSIBLE";
            }
            return "POSSIBLE";
        }
    }
}
