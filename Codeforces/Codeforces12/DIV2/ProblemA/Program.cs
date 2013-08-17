using System;

namespace A.Super_Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[3];
            for (int i = 0; i < 3; i++)
                input[i] = Console.ReadLine();
            bool finish = false;
            if (input[0][0] != input[2][2])
            {
                Console.WriteLine("NO");
                finish = true;
            }
            if (finish == false)
            {
                if (input[1][0] != input[1][2])
                {
                    Console.WriteLine("NO");
                    finish = true;
                }
            }
            if (finish == false)
            {
                if (input[2][0] != input[0][2])
                {
                    Console.WriteLine("NO");
                    finish = true;
                }
            }
            if (finish == false)
            {
                if (input[0][1] != input[2][1])
                {
                    Console.WriteLine("NO");
                    finish = true;
                }
            }
            if(!finish)
                Console.WriteLine("YES");
            Console.ReadLine();
        }
    }
}
