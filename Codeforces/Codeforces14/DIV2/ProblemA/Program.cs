using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace A.Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] total = new string[int.Parse(input[0])];
            for (int i = 0; i < total.Length; i++)
                total[i] = Console.ReadLine();
            Regex r = new Regex("[*]");
            int xMin = 0;
            int xMax = 0;
            for (int i = 0; i < total.Length; i++)
            {
                if (total[i].Contains("*"))
                {
                    xMin = i;
                    break;
                }
            }
            for (int i = total.Length - 1; i >= 0; i--)
            {
                if (total[i].Contains("*"))
                {
                    xMax = i;
                    break;
                }
            }
            int min = 1000000;
            int max = 0;
            for (int i = 0; i < total.Length; i++)
            {
                if (total[i].Contains("*"))
                {
                    List<int> indices = new List<int>();
                    foreach (Match m in r.Matches(total[i]))
                        indices.Add(m.Index);
                    if (indices[0] < min)
                        min = indices[0];
                    if (indices[indices.Count - 1] > max)
                        max = indices[indices.Count - 1];
                }
            }
            List<string> result = new List<string>();
            for (int i = xMin; i <= xMax; i++)
                result.Add(total[i].Substring(min, (max - min) + 1));
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine(result[i]);
            Console.ReadLine();
        }
    }
}
