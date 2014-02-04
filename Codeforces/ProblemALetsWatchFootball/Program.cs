using System;
using System.Linq;

namespace LetsWatchFootball
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int temp = (input[0] * input[2]) - (input[1] * input[2]);
            int seconds = 0;
            while (seconds * input[1] < temp)
                seconds++;
            Console.WriteLine(seconds);
            Console.ReadLine();
        }
    }
}
