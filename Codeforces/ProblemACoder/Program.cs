using System;

namespace ProblemACoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] board = new string[cases];
            int res = 0;
            for (int i = 0; i < cases; i++)
            {
                if (i % 2 == 0)
                {
                    for (int a = 0; a < cases; a++)
                    {
                        board[i] += (a % 2 == 0) ? "C" : ".";
                    }
                    res += (cases + 1) / 2;
                }
                else
                {
                    for (int a = 0; a < cases; a++)
                    {
                        board[i] += (a % 2 == 1) ? "C" : ".";
                    }
                    res += cases / 2;
                }
            }
            Console.WriteLine(res);
            foreach(string b in board)
                Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
