using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace LittlePigsAndWolves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int lenght = cases[1] + 2;
            string line = "";
            for (int i = 0; i < lenght; i++)
                line += ".";
            string[] board = new string[cases[0] + 2];
            board[0] = line;
            for (int i = 1; i < board.Length - 1; i++)
                board[i] = "." + Console.ReadLine() + ".";
            board[board.Length - 1] = line;
            int result = 0;
            for (int i = 1; i < board.Length - 1; i++)
            {
                for (int a = 0; a < board[i].Length; a++)
                {
                    if (board[i][a] == 'W')
                    {
                        if (board[i][a - 1] == 'P')
                        {
                            result++;
                            board[i] = board[i].Insert(a - 1, ".");
                            board[i] = board[i].Remove(a, 1);
                        }
                        else if (board[i - 1][a] == 'P')
                        {
                            result++;
                            board[i - 1] = board[i - 1].Insert(a, ".");
                            board[i - 1] = board[i - 1].Remove(a + 1, 1);
                        }
                        else if (board[i][a + 1] == 'P')
                        {
                            result++;
                            board[i] = board[i].Insert(a + 1, ".");
                            board[i] = board[i].Remove(a + 2, 1);
                        }
                        else if (board[i + 1][a] == 'P')
                        {
                            result++;
                            board[i + 1] = board[i + 1].Insert(a, ".");
                            board[i + 1] = board[i + 1].Remove(a + 1, 1);
                        }
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
