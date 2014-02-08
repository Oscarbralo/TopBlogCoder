using System;
using System.Linq;
using System.Text;

namespace CollectingBeatIsFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int hands = int.Parse(Console.ReadLine());
            StringBuilder board = new StringBuilder();
            for (int i = 0; i < 4; i++)
                board.Append(Console.ReadLine());
            bool finish = true;
            for (int i = 1; i <= 9; i++)
            {
                if (board.ToString().Count(x => x.ToString() == i.ToString()) > hands * 2)
                    finish = false;
            }
            if(finish)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
