using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            OnLineRank a = new OnLineRank();
            int[] x = { 6, 9, 8, 15, 7, 12 };
            Console.WriteLine(a.calcRanks(3,x));
            Console.ReadLine();
        }
    }

    public class OnLineRank
    {
        public int calcRanks(int k, int[] scores)
        {
            int result = 0;
            int[] ranks = new int[scores.Length];
            for (int a = scores.Length - 1; a >= 0; a--)
            {
                int rank = 1;
                if (a - k >= 0)
                {
                    for (int b = a - 1; b >= a - k; b--)
                    {
                        if (scores[a] < scores[b])
                            rank++;
                    }
                }
                else
                {
                    for (int b = a - 1; b >= 0; b--)
                    {
                        if (scores[a] < scores[b])
                            rank++;
                    }
                }
                ranks[a] = rank;
                result += rank;
            }
            return result;
        }
    }
}
