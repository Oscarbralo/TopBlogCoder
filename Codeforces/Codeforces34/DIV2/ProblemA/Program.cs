using System;

namespace A.Reconnaissance_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] sol = Console.ReadLine().Split(' ');
            int[] soldiers = new int[cases + 1];
            for (int i = 0; i < sol.Length; i++)
            {
                soldiers[i] = int.Parse(sol[i]);
            }
            soldiers[soldiers.Length - 1] = int.Parse(sol[0]);
            int min = 10000000;
            string result = "";
            for (int i = 0; i < soldiers.Length - 1; i++)
            {
                int dif = Math.Abs(soldiers[i] - soldiers[i + 1]);
                if (dif < min)
                {
                    min = dif;
                    if(i == sol.Length - 1)
                        result = (i + 1).ToString() + " 1";
                    else
                        result = (i + 1).ToString() + " " + (i + 2).ToString();
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
