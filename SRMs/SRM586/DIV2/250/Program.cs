using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamsSelection a = new TeamsSelection();
            int[] x = { 3, 2, 1 };
            int[] xx = { 1, 3, 2 };
            Console.WriteLine(a.simulate(x,xx));
            Console.ReadLine();
        }
    }

    public class TeamsSelection
    {
        public string simulate(int[] preference1, int[] preference2)
        {
            bool[] chosen = new bool[preference1.Length];
            int[] result = new int[chosen.Length];
            for (int a = 0; a < preference1.Length; a++)
            {
                if (a % 2 == 0)
                {
                    for (int b = 0; b < preference1.Length; b++)
                    {
                        if (chosen[preference1[b] - 1] == false)
                        {
                            chosen[preference1[b] - 1] = true;
                            result[preference1[b] - 1] = 1;
                            break;
                        }
                    }
                }
                else
                {
                    for (int c = 0; c < preference2.Length; c++)
                    {
                        if (chosen[preference2[c] - 1] == false)
                        {
                            chosen[preference2[c] - 1] = true;
                            result[preference2[c] - 1] = 2;
                            break;
                        }
                    }
                }
            }
            StringBuilder sr = new StringBuilder();
            for (int d = 0; d < result.Length; d++)
                sr.Append(result[d].ToString());
            return sr.ToString();
        }
    }
}
