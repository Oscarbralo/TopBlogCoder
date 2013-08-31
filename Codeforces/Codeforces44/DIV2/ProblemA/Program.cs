using System;
using System.Collections.Generic;

namespace A.Indian_Summer
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < cases; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                if (!list.Contains(temp[0] + " " + temp[1]))
                {
                    if (temp[0] != temp[1])
                    {
                        list.Add(temp[0] + " " + temp[1]);
                    }
                }
            }
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}
