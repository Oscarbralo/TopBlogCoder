using System;

namespace Enormous_Input_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cases = Console.ReadLine().Split(' ');
            long res = 0;
            for (int i = 0; i < int.Parse(cases[0]); i++)
            {
                long temp = long.Parse(Console.ReadLine());
                if (temp % long.Parse(cases[1]) == 0)
                    res++;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
