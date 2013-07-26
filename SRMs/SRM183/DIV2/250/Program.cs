using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            CountGame a = new CountGame();
            Console.WriteLine(a.howMany(8, 800, 793));
            Console.ReadLine();
        }
    }

    public class CountGame
    {
        public int howMany(int maxAdd, int goal, int next)
        {
            int result = -1;
            if (goal == next || goal - maxAdd < next)
                result = (goal - next) + 1;
            else
            {
                List<int> list = new List<int>();
                while (goal > next)
                {
                    goal -= maxAdd + 1;
                    list.Add(goal);
                }
                int temp = 1;
                for (int a = next; a < next + maxAdd; a++)
                {
                    if (list.Contains(a))
                    {
                        result = temp;
                        break;
                    }
                    temp++;
                }
            }
            return result;
        }
    }
}
