using System;
using System.Collections.Generic;

namespace A.Worms_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] inp = Console.ReadLine().Split(' ');
            List<int> input = new List<int>();
            for (int i = 0; i < inp.Length; i++)
                input.Add(int.Parse(inp[i]));
            string result = "-1";
            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int a = i + 1; a < input.Count; a++)
                {
                    if (input.Contains(input[i] + input[a]))
                    {
                        result = (input.IndexOf(input[i] + input[a]) + 1).ToString() + " " + (a + 1).ToString() + " " + (i + 1).ToString();
                        break;
                    }
                }
                if (result != "-1")
                    break;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
