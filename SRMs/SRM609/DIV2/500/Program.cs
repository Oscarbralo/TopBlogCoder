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
            PackingBallsDiv2 x = new PackingBallsDiv2();
            Console.WriteLine(x.minPacks(0, 2, 1));
            Console.ReadLine();
        }
    }

    public class PackingBallsDiv2
    {
        public int minPacks(int R, int G, int B)
        {
            int boxes = 0;
            while (R > 3)
            {
                R -= 3;
                boxes++;
            }
            while (G > 3)
            {
                G -= 3;
                boxes++;
            }
            while (B > 3)
            {
                B -= 3;
                boxes++;
            }
            while (R > 0 || G > 0 || B > 0)
            {
                int count = 0;
                if (R > 0)
                {
                    R--; 
                    count++;
                }
                if (G > 0)
                {
                    G--;
                    count++;
                }
                if (B > 0)
                {
                    B--;
                    count++;
                }
                if (count == 1)
                {
                    if (R > 0)
                    {
                        R--;
                        count++;
                    }
                    if (G > 0)
                    {
                        G--;
                        count++;
                    }
                    if (B > 0)
                    {
                        B--;
                        count++;
                    }
                }
                boxes++;
            }
            return boxes;
        }
    }
}
