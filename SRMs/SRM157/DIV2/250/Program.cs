using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessTheNumber x = new GuessTheNumber();
            Console.WriteLine(x.noGuesses(9,6));
            Console.ReadLine();
        }
    }

    public class GuessTheNumber
    {
        public int noGuesses(int upper, int answer)
        {
            int res = 0;
            int lower = 1;
            int temp = 0;
            while (temp != answer)
            {
                temp = (lower + upper) / 2;
                if (temp == answer)
                {
                    res++;
                    break;
                }
                else if (temp < answer)
                {
                    lower = temp + 1;
                    res++;
                }
                else if (temp > answer)
                {
                    upper = temp - 1;
                    res++;
                }
            }
            return res;
        }
    }
}
