using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            RaiseThisBarn x = new RaiseThisBarn();
            Console.WriteLine(x.calc(".c.c...c..ccc.c..c.c.cc..ccc"));
            Console.ReadLine();
        }
    }

    public class RaiseThisBarn
    {
        public int calc(string str)
        {
            Regex r = new Regex("c");
            int cows = r.Matches(str).Count;
            if(cows % 2 == 0)
            {
                if (cows == 0)
                    return str.Length - 1;
                int spaces = 0;
                int half = cows / 2;
                bool finish = false;
                for (int i = 0; i < str.Length; i++)
                {
                    if(str[i] == 'c')
                        half--;
                    if (half == 0)
                    {
                        for (int a = i + 1; a < str.Length; a++)
                        {
                            if(str[a] == '.')
                                spaces++;
                            else
                            {
                                finish = true;
                                break;
                            }
                        }
                    }
                    if(finish)
                        break;
                }
                return spaces + 1;
            }
            else
                return 0;
        }
    }
}
