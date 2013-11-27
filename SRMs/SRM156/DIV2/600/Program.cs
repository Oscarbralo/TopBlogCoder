using System;

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
            string[] newBoard = new string[board.Length + 2];
            newBoard[0] = "." + board[0].Replace("B", ".") + ".";
            for (int i = 0; i < board.Length; i++)
                newBoard[i + 1] = "." + board[i] + ".";
            newBoard[newBoard.Length - 1] = newBoard[0];
            int result = 0;
            int bombs = 0;
            for (int a = 1; a < newBoard.Length - 1; a++)
            {
                for (int b = 1; b < newBoard[a].Length - 1; b++)
                {
                    if (newBoard[a][b] == 'B')
                        bombs++;
                    else
                    {
                        if(check(newBoard, a, b))
                            result++;
                    }
                }
            }
            double res = double.Parse(result.ToString()) / (double.Parse(result.ToString()) + double.Parse(bombs.ToString()));
            double r = res * 100.0;
            return r;
        }

        public bool check(string[] newBoard, int a, int b)
        {
            int count = 0;
            if (newBoard[a - 1][b] == '.')
                count++;
            if (newBoard[a - 1][b - 1] == '.')
                count++;
            if (newBoard[a][b - 1] == '.')
                count++;
            if (newBoard[a + 1][b - 1] == '.')
                count++;
            if (newBoard[a + 1][b] == '.')
                count++;
            if (newBoard[a + 1][b + 1] == '.')
                count++;
            if (newBoard[a][b + 1] == '.')
                count++;
            if (newBoard[a - 1][b + 1] == '.')
                count++;
            return (count == 8) ? true : false;
        }
    }
}
