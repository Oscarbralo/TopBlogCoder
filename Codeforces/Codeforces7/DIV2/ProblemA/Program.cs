using System;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board = new string[8];
            int count = 0;
            bool x = false;
            for (int i = 0; i < board.Length; i++)
                board[i] = Console.ReadLine();
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].StartsWith("B") && !board[i].Contains("W"))
                {
                    count++;
                }
                if (board[i].Contains("B") && i < 1)
                {
                    for (int a = 0; a < board[i].Length; a++)
                    {
                        if (board[i][a].ToString() == "B")
                        {
                            int tot = 0;
                            for (int c = 0; c < board.Length; c++)
                            {
                                if (board[c][a].ToString() == "B")
                                    tot++;
                            }
                            if (tot == 8)
                                count++;
                        }
                    }
                }
            }
            if (count == 16)
                count = 8;
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
