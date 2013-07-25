using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            CrossWord s = new CrossWord();
            string[] a = { "........X.X.XX...X.XX.....XX...X.X....X........", ".......X.......X....X.XX.....X...X.X.X.XX.XX..X", "....X....X..XX..X......XXX...X.X...X..........." }
;
            Console.WriteLine(s.countWords(a, 3));
            Console.ReadLine();
        }
    }

    public class CrossWord
    {
        public int countWords(string[] board, int size)
        {
            int result = 0;
            int temp = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < board.Length; i++)
            {
                temp = 0;
                for (int a = 0; a < board[i].Length; a++)
                {
                    if (board[i][a].ToString() == ".")
                        temp++;
                    else
                    {
                        if (temp > 1)
                        {
                            list.Add(temp);
                        }
                        temp = 0;
                    }
                }
                if (temp > 1)
                {
                    list.Add(temp);
                    temp = 0;
                }
            }
            list.Add(temp);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == size)
                    result++;
            }
            return result;
        }
    }
}
