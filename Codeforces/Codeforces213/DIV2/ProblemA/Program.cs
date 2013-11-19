using System;

namespace ProblemA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int cases = int.Parse(input[0]);
            int maxNumber = int.Parse(input[1]);
            int result = 0;
            for (int i = 0; i < cases; i++)
            {
                string n = Console.ReadLine();
                bool finish = false;
                for (int a = 0; a <= maxNumber; a++)
                {
                    if (!n.Contains(a.ToString()))
                    {
                        finish = true;
                        break;
                    }
                }
                if (!finish)
                    result++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}