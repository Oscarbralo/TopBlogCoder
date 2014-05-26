using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace TheLeadGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int player1 = 0;
            int player2 = 0;
            int winner = 0;
            int max = 0;
            for (int i = 0; i < cases; i++)
            {
                int[] points = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                player1 += points[0];
                player2 += points[1];
                if (player1 > player2)
                {
                    if (player1 - player2 > max)
                    {
                        winner = player1;
                        max = player1 - player2;
                    }
                }
                else
                {
                    if (player2 - player1 > max)
                    {
                        winner = player2;
                        max = player2 - player1;
                    }
                }
            }
            Console.WriteLine(string.Format("{0} {1}", winner, max));
            Console.ReadLine();
        }
    }
}
