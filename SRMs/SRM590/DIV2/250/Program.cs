using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            FoxAndGomoku x = new FoxAndGomoku();
            string[] a = { "o", "o" };
            Console.WriteLine(x.win(a));
            Console.ReadLine();
        }
    }

    public class FoxAndGomoku
    {
        public string win(string[] board)
        {
            string result = "not found";
            bool finish = false;
            for (int i = 0; i < board.Length; i++)
            {
                for (int a = 0; a < board[i].Length; a++)
                {
                    if (board[i][a] == 'o')
                    {
                        int count = 0;
                        for (int b = a; b < board[i].Length; b++)
                        {
                            if (board[i][b] == 'o')
                                count++;
                            else
                                break;
                        }
                        if (count >= 5)
                        {
                            finish = true;
                            result = "found";
                            break;
                        }
                        count = 0;
                        for (int c = i; c < board.Length; c++)
                        {
                            if (board[c][a] == 'o')
                                count++;
                            else
                                break;
                        }
                        if (count >= 5)
                        {
                            finish = true;
                            result = "found";
                            break;
                        }
                        count = 0;
                        int j = a;
                        for (int d = i; d < board.Length; d++)
                        {
                            if (j >= board[i].Length)
                                break;
                            if (board[d][j] == 'o')
                                count++;
                            else
                                break;
                            j++;
                        }
                        if (count >= 5)
                        {
                            finish = true;
                            result = "found";
                            break;
                        }
                        count = 0;
                        j = a;
                        for (int e = i; e < board.Length; e++)
                        {
                            if (j < 0)
                                break;
                            if (board[e][j] == 'o')
                                count++;
                            else
                                break;
                            j--;
                        }
                        if (count >= 5)
                        {
                            finish = true;
                            result = "found";
                            break;
                        }
                    }
                }
                if (finish)
                    break;
            }
            return result;
        }
    }
}
