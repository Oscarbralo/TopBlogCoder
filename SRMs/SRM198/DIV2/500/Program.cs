using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            RedSquare x = new RedSquare();
            int[] a = { 1 };
            int[] b = { 1 };
            Console.WriteLine(x.countTheEmptyReds(6, 5, a, b));
            Console.ReadLine();
        }
    }

    public class RedSquare
    {
        public int countTheEmptyReds(int maxRank, int maxFile, int[] rank, int[] file)
        {
            int reds = 0;
            if (maxFile % 2 == 0)
            {
                if(maxRank % 2 == 0)
                    reds = ((maxFile / 2) * (maxRank / 2)) + ((maxFile / 2) * (maxRank / 2));
                else
                    reds = ((maxFile / 2) * ((maxRank / 2) + 1)) + ((maxFile / 2) * (maxRank / 2));
                for (int i = 0; i < rank.Length; i++)
                {
                    if (rank[i] % 2 == 1)
                    {
                        if (file[i] % 2 == 1)
                            reds--;
                    }
                    else
                    {
                        if (file[i] % 2 == 0)
                            reds--;
                    }
                }
            }
            else
            {
                if(maxRank % 2 == 0)
                    reds = ((maxFile / 2) * (maxRank / 2)) + (((maxFile / 2) + 1) * (maxRank / 2));
                else
                    reds = ((maxFile / 2) * ((maxRank / 2) + 1)) + (((maxFile / 2) + 1) * (maxRank / 2));
                for (int i = 0; i < rank.Length; i++)
                {
                    if (rank[i] % 2 == 1)
                    {
                        if (file[i] % 2 == 0)
                            reds--;
                    }
                    else
                    {
                        if (file[i] % 2 == 1)
                            reds--;
                    }
                }
            }
            return reds;
        }
    }
}
