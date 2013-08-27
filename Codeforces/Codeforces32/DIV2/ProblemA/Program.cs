using System;

namespace A.Reconnaissance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] soldiers = Console.ReadLine().Split(' ');
            int[] sol = new int[soldiers.Length];
            int diff = int.Parse(input[1]);
            for (int i = 0; i < soldiers.Length; i++)
                sol[i] = int.Parse(soldiers[i]);
            int result = 0;
            for (int i = 0; i < sol.Length; i++)
            {
                for (int a = 0; a < sol.Length; a++)
                {
                    if (a == i)
                        continue;
                    if (Math.Abs(sol[i] - sol[a]) <= diff)
                        result++;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
