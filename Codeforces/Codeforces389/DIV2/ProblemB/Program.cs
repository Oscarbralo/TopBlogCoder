using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string temp = "";
            for (int i = 0; i < n + 2; i++)
                temp += ".";
            List<string> board = new List<string>();
            board.Add(temp);
            for (int i = 0; i < n; i++)
                board.Add("." + Console.ReadLine() + ".");
            board.Add(temp);
            string resultTemp = string.Join("", board.ToArray<string>());
            if (resultTemp.Where(x => x == '#').Count() % 5 == 0)
            {
                for (int i = 1; i < board.Count; i++)
                {
                    for (int a = 0; a < board[i].Length; a++)
                    {
                        if (board[i][a] == '#')
                        {
                            if (board[i][a + 1] == '#' && board[i + 1][a] == '#' && board[i][a - 1] == '#' && board[i - 1][a] == '#')
                            {
                                board[i] = board[i].Insert(a, ".");
                                board[i] = board[i].Remove(a + 1, 1);
                                board[i] = board[i].Insert(a + 1, ".");
                                board[i] = board[i].Remove(a + 2, 1);
                                board[i + 1] = board[i + 1].Insert(a, ".");
                                board[i + 1] = board[i + 1].Remove(a + 1, 1);
                                board[i] = board[i].Insert(a - 1, ".");
                                board[i] = board[i].Remove(a, 1);
                                board[i - 1] = board[i - 1].Insert(a, ".");
                                board[i - 1] = board[i - 1].Remove(a + 1, 1);
                            }
                        }
                    }
                }
                string result = string.Join("", board.ToArray<string>());
                Console.WriteLine(result.Where(x => x == '#').Count() > 0 ? "NO" : "YES");
            }
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}