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
            BlackAndRed x = new BlackAndRed();
            Console.WriteLine(x.cut("RBRBBRRRRBBBRBBRRBRBBRRRBRBBBRBRBRBRBRRB"));
            Console.ReadLine();
        }
    }

    public class BlackAndRed
    {
        public int cut(string deck)
        {
            int result = 0;
            for (int i = 0; i < deck.Length; i++)
            {
                string begin = string.Join("", deck.Take(i).Select(x => x.ToString()).ToArray<string>());
                string temp = deck.Substring(i, deck.Length - i) + begin;
                bool finish = true;
                int red = 0;
                int black = 0;
                for (int a = 0; a < temp.Length; a++)
                {
                    if (red > black)
                    {
                        finish = false;
                        break;
                    }
                    else
                    {
                        if (temp[a] == 'R')
                            red++;
                        else
                            black++;
                    }
                }
                if (finish)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
