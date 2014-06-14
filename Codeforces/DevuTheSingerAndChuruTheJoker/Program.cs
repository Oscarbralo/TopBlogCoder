using System;
using System.Collections.Generic;
using System.Linq;

namespace DevuTheSingerAndChuruTheJoker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            List<int> songs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int jokes = 0;
            while (songs.Count > 0)
            {
                cases[1] -= songs[0];
                songs.RemoveAt(0);
                if (songs.Count != 0)
                {
                    cases[1] -= 10;
                    jokes += 2;
                }
            }
            if (cases[1] < 0)
                Console.WriteLine(-1);
            else
            {
                jokes += (cases[1] / 5);
                Console.WriteLine(jokes);
            }
            Console.ReadLine();
        }
    }
}
