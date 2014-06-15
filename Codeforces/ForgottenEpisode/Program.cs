using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ForgottenEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxEpisodes = int.Parse(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(1, maxEpisodes).Except(Console.ReadLine().Split(' ').Select(x => int.Parse(x))).ToList()[0]);
        }
    }
}
