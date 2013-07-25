using System;
using System.Collections.Generic;

namespace C.Alice__Bob_and_Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] list = Console.ReadLine().Split(' ');
            int[] temp1 = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
                temp1[i] = int.Parse(list[i]);
            if (temp1.Length == 1)
                Console.WriteLine("1 0");
            else
            {
                int aliceTotal = 0;
                int bobTotal = 0;
                int alice = 0;
                int bob = temp1.Length - 1;
                while (alice != bob)
                {
                    if (temp1[alice] <= temp1[bob])
                    {
                        aliceTotal++;
                        while (temp1[alice] > 0)
                        {
                            temp1[alice]--;
                            temp1[bob]--;
                        }
                        alice++;
                        if (alice == bob)
                            bobTotal++;
                    }
                    else
                    {
                        bobTotal++;
                        while (temp1[bob] > 0)
                        {
                            temp1[bob]--;
                            temp1[alice]--;
                        }
                        bob--;
                        if (bob == alice)
                            aliceTotal++;
                    }
                }
                Console.WriteLine(aliceTotal.ToString() + " " + bobTotal.ToString());
            }
            Console.ReadLine();
        }
    }
}
