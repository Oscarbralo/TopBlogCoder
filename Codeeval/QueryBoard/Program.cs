using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace QueryBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] board = new int[256][];
            for (int i = 0; i < board.Length; i++)
                board[i] = new int[256];
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
            for (int b = 0; b < 255; b++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int x = 0;
                int y = 0;
                int result = 0;
                switch (input[0])
                {
                    case "SetCol":
                        x = int.Parse(input[1]);
                y = int.Parse(input[2]);
                        for (int i = 0; i < board.Length; i++)
                            board[i][x] = y;
                        break;
                    case "SetRow":
                        x = int.Parse(input[1]);
                y = int.Parse(input[2]);
                        for (int i = 0; i < board[x].Length; i++)
                            board[x][i] = y;
                        break;
                    case "QueryCol":
                        x = int.Parse(input[1]);
                        for (int i = 0; i < board.Length; i++)
                            result += board[i][x];
                        Console.WriteLine(result);
                        break;
                    case "QueryRow":
                        x = int.Parse(input[1]);
                        for (int i = 0; i < board[x].Length; i++)
                            result += board[x][i];
                        Console.WriteLine(result);
                        break;
                    default:
                        break;
                }
            }
                //}
            Console.ReadLine();
        }
    }
}
