using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _600
{
    class Program
    {
        static void Main(string[] args)
        {
            BombSweeper x = new BombSweeper();
            string[] a = {".....",
 ".....",
 "..B..",
 ".....",
 "....."};
            Console.WriteLine(x.winPercentage(a));
            Console.ReadLine();
        }
    }

    public class BombSweeper
    {
        public double winPercentage(string[] board)
        {
            double total = 0.0;
            double totalNo = 0.0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int a = 0; a < board[i].Length; a++)
                {
                    if (board[i][a] == 'B')
                    {
                        totalNo++;
                        continue;
                    }
                    if (i - 1 >= 0)
                    {
                        if (board[i - 1][a] == 'B')
                            continue;
                    }
                    if (i - 1 >= 0 && a + 1 < board[i].Length)
                    {
                        if (board[i - 1][a + 1] == 'B')
                            continue;
                    }
                    if (a + 1 < board[i].Length)
                    {
                        if (board[i][a + 1] == 'B')
                            continue;
                    }
                    if (a + 1 < board[i].Length && i + 1 < board.Length)
                    {
                        if (board[i + 1][a + 1] == 'B')
                            continue;
                    }
                    if (i + 1 < board.Length)
                    {
                        if (board[i + 1][a] == 'B')
                            continue;
                    }
                    if (i + 1 < board.Length && a - 1 >= 0)
                    {
                        if (board[i + 1][a - 1] == 'B')
                            continue;
                    }
                    if (a - 1 >= 0)
                    {
                        if (board[i][a - 1] == 'B')
                            continue;
                    }
                    if (a - 1 >= 0 && i - 1 >= 0)
                    {
                        if (board[i - 1][a - 1] == 'B')
                            continue;
                    }
                    total++;
                }
            }
            double res = (total * 100.0) / (total + totalNo);
            return res;
        }
    }
}
