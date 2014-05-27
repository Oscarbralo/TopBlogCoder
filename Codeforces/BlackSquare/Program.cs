using System;
using System.Linq;

namespace BlackSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[] n = Console.ReadLine().Select(x => int.Parse(x.ToString()) - 1).ToArray<int>();
            long result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                result += numbers[n[i]];
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
