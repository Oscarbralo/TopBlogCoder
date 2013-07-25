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
            Animation x = new Animation();
            Console.WriteLine(x.animate(1, "LRRL.LR.LRR.R.LRRL."));
            Console.ReadLine();
        }
    }

    public class Animation
    {
        public string[] animate(int speed, string init)
        {
            List<string> res = new List<string>();
            Queue<int> left = new Queue<int>();
            Queue<int> right = new Queue<int>();
            string temp = "";
            int totalParticlesL = 0;
            int totalParticlesR = 0;
            for (int i = 0; i < init.Length; i++)
            {
                if (init[i] == 'L')
                {
                    left.Enqueue(i);
                    totalParticlesL++;
                    temp += "X";
                }
                else if (init[i] == 'R')
                {
                    right.Enqueue(i);
                    totalParticlesR++;
                    temp += "X";
                }
                else
                    temp += ".";
            }
            res.Add(temp);
            while (temp.Contains("X"))
            {
                temp = "";
                for (int i = 0; i < init.Length; i++)
                    temp += ".";
                int indexTemp = 0;
                int L = totalParticlesL;
                int R = totalParticlesR;
                int total = totalParticlesL + totalParticlesR;
                for (int i = 0; i < total; i++)
                {
                    if (L > 0)
                    {
                        indexTemp = left.Dequeue();
                        if (indexTemp - speed < 0)
                            totalParticlesL--;
                        else
                        {
                            left.Enqueue(indexTemp - speed);
                            temp = temp.Insert(indexTemp - speed, "X");
                            temp = temp.Remove(indexTemp - speed + 1, 1);
                        }
                        L--;
                    }
                    if (R > 0)
                    {
                        indexTemp = right.Dequeue();
                        if (indexTemp + speed > temp.Length - 1)
                            totalParticlesR--;
                        else
                        {
                            right.Enqueue(indexTemp + speed);
                            temp = temp.Insert(indexTemp + speed, "X");
                            temp = temp.Remove(indexTemp + speed + 1, 1);
                        }
                        R--;
                    }
                }
                res.Add(temp);
            }
            return res.ToArray();
        }
    }
}
