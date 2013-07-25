using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            PaperFold x = new PaperFold();
            int[] a = { 8, 11 };
            int[] b = { 6, 10 };
            Console.WriteLine(x.numFolds(a, b));
            Console.ReadLine();
        }
    }

    public class PaperFold
    {
        public int numFolds(int[] paper, int[] box)
        {
            int res = 0;
            double[] pape = new double[2];
            double[] bo = new double[2];
            for (int i = 0; i < paper.Length; i++)
            {
                pape[i] = (double)paper[i];
                bo[i] = (double)box[i];
            }
            for (int i = 0; i < 9; i++)
            {
                if (pape[0] > pape[1])
                {
                    if (pape[0] <= bo[0])
                    {
                        if (pape[1] <= bo[1])
                            return res;
                        else
                        {
                            pape[1] /= 2;
                            res++;
                        }
                    }
                    else if(pape[0] <= bo[1])
                    {
                        if (pape[1] <= bo[0])
                            return res;
                        else
                        {
                            pape[1] /= 2;
                            res++;
                        }
                    }
                    else
                    {
                        pape[0] /= 2;
                        res++;
                    }
                }
                else
                {
                    if (pape[1] <= bo[0])
                    {
                        if (pape[0] <= bo[1])
                            return res;
                        else
                        {
                            pape[0] /= 2;
                            res++;
                        }
                    }
                    else if (pape[1] <= bo[1])
                    {
                        if (pape[0] <= bo[0])
                            return res;
                        else
                        {
                            pape[0] /= 2;
                            res++;
                        }
                    }
                    else
                    {
                        pape[1] /= 2;
                        res++;
                    }
                }
            }
            return -1;
        }
    }
}
