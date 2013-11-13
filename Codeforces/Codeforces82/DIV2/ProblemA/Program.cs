using System;

namespace DoubleCola
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int db = 1;
            int index = 0;
            string[] winner = { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard"};
            while (n >= 1)
            {
                index = 0;
                for (int i = 0; i < winner.Length; i++)
                {
                    n -= db;
                    if (n <= 0) { break; }
                    index++;
                }
                db *= 2;
            }
            Console.WriteLine(winner[index]);
            Console.ReadLine();
        }
    }
}
