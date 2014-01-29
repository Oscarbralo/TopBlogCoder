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
            ThirtyOne x = new ThirtyOne();
            string[] cards = { "K 4 K", "2 10 7", "10 A 9", "10 J K", "2 6 7", "3 5 7", "9 8 8", "2 J 10", "9 8 2", "10 3 3", "A 8 8", "7 9 6", "8 Q J", "10 10 K", "3 8 J", "10 K 8", "A 7 3", "Q Q 5", "J 4 A", "9 3 10", "2 K 4", "10 4 9", "K 8 8", "4 5 9", "Q J Q", "7 5 A", "7 8 5", "4 7 4", "3 A K", "8 K 8", "10 J Q", "A 4 2", "6 5 8", "A 7 4", "2 5 8", "2 3 A", "Q 8 10", "3 K K", "9 A 3", "3 Q A", "10 K 2", "4 A A", "3 2 K" };
            Console.WriteLine(x.findWinner(cards));
            Console.ReadLine();
        }
    }

    public class ThirtyOne
    {
        public int findWinner(string[] hands)
        {
            int winnerIndex = 0;
            double maxValue = 0;
            for( int i = 0; i < hands.Length; i++)
            {
                string[] firstCheck = hands[i].Split(' ');
                if (firstCheck[0] == firstCheck[1] && firstCheck[0] == firstCheck[2])
                {
                    if (30.5 > maxValue)
                    {
                        maxValue = 30.5;
                        winnerIndex = i;
                    }
                }
                int[] cards = hands[i].Replace("J", "10").Replace("Q", "10").Replace("K", "10").Replace("A", "1")
                    .Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                int aces = cards.Count(x => x == 1);
                double sum = cards.Sum();
                while (sum + 10 <= 31 && aces > 0)
                {
                    sum += 10;
                    aces--;
                }
                if (sum > maxValue)
                {
                    maxValue = sum;
                    winnerIndex = i;
                }
            }
            return winnerIndex;
        }
    }
}
