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
            int[] b = { 1};
            Console.WriteLine(x.countTheEmptyReds(50, 50, a, b));
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
                for (int i = 1; i <= maxRank; i++)
                {
                    if (i % 2 == 1)
                    {
                        for (int a = 1; a <= maxFile; a++)
                        {
                            reds += (a % 2 == 1) ? 1 : 0;
                        }
                    }
                    else
                    {
                        for (int b = 1; b <= maxFile; b++)
                        {
                            reds += (b % 2 == 0) ? 1 : 0;
                        }
                    }
                }
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
                for (int i = 1; i <= maxRank; i++)
                {
                    if (i % 2 == 1)
                    {
                        for (int a = 1; a <= maxFile; a++)
                        {
                            reds += (a % 2 == 0) ? 1 : 0;
                        }
                    }
                    else
                    {
                        for (int b = 1; b <= maxFile; b++)
                        {
                            reds += (b % 2 == 1) ? 1 : 0;
                        }
                    }
                }
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
