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
            PaperFold x = new PaperFold();
            int[] a = { 2528, 3911 };
            int[] b = { 4079, 639 };
            Console.WriteLine(x.numFolds(a,b));
            Console.ReadLine();
        }
    }

    public class PaperFold
    {
        public int numFolds(int[] paper, int[] box)
        {
            int result = 0;
            bool finish = false;
            double[] p = {(double)paper[0], (double)paper[1]};
            double[] b = {(double)box[0], (double)box[1]};
            for (int i = 0; i <= 8; i++)
            {
                if ((p[0] <= b[0] && p[1] <= b[1]) || (p[0] <= b[1] && p[1] <= b[0]))
                {
                    finish = true;
                    break;
                }
                if (p[0] > p[1])
                {
                    if (p[0] <= b[0] || p[0] <= b[1])
                        p[1] /= 2;
                    else if (p[1] <= b[1] || p[1] <= b[1])
                        p[0] /= 2;
                    else
                        if (p[0] >= p[1])
                            p[0] /= 2;
                        else
                            p[1] /= 2;
                }
                else
                {
                    if (p[1] <= b[0] || p[1] <= b[1])
                        p[0] /= 2;
                    else if (p[0] <= b[0] || p[0] <= b[1])
                        p[1] /= 2;
                    else
                        if (p[0] >= p[1])
                            p[0] /= 2;
                        else
                            p[1] /= 2;
                }
                result++;
            }
            if(finish)
                return result;
            else
                return -1;
        }
    }
}
