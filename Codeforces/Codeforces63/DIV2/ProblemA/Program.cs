using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace A.Sinking_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < cases; i++)
                list.Add(Console.ReadLine());
            string[] order = { "rat", "woman", "man", "captain"};
            int current = 0;
            while (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string[] input = list[i].Split(' ');
                    if (current == 1)
                    {
                        if (order[current] == input[1] || input[1] == "child")
                        {
                            Console.WriteLine(input[0]);
                            list.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        if (order[current] == input[1])
                        {
                            Console.WriteLine(input[0]);
                            list.RemoveAt(i);
                            i--;
                        }
                    }
                }
                current++;
            }
            Console.ReadLine();
        }
    }
}
