using System;
using System.Linq;

namespace KitaharaHarukisGift
{
    class Program
    {
        static void Main(string[] args)
        {
            int apples = int.Parse(Console.ReadLine());
            int[] grams = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderByDescending(x => x).ToArray<int>();
            int friend1 = 0;
            int friend2 = 0;
            for (int i = 0; i < grams.Length; i++)
            {
                if (friend1 <= friend2)
                    friend1 += grams[i];
                else
                    friend2 += grams[i];
            }
            Console.WriteLine(friend1 == friend2 ? "YES" : "NO");
            Console.ReadLine();
        }
    }
}
