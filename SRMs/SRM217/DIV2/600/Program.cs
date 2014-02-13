using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _600
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame x = new PlayGame();
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] b = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(x.saveCreatures(a, b));
            Console.ReadLine();
        }
    }

    public class PlayGame
    {
        public int saveCreatures(int[] you, int[] computer)
        {
            List<int> youSorted = you.OrderByDescending(x => x).ToList();
            List<int> computerSorted = computer.OrderByDescending(x => x).ToList();
            for (int i = 0; i < youSorted.Count; i++)
            {
                bool finish = false;
                for (int a = 0; a < computerSorted.Count; a++)
                {
                    if (youSorted[i] > computerSorted[a])
                    {
                        computerSorted.RemoveAt(a);
                        finish = true;
                        break;
                    }
                }
                if (finish == false)
                {
                    youSorted.RemoveAt(i);
                    i--;
                }
            }
            return youSorted.Sum();
        }
    }
}
