using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace A.Cakeminator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] grid = Console.ReadLine().Split(' ');
            int rows = int.Parse(grid[0]);
            int colums = int.Parse(grid[1]);
            bool max = rows > colums ? true : false;
            int result = 0;
            List<int> strawRows = new List<int>();
            List<int> strawColums = new List<int>();
            string[] g = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                g[i] = Console.ReadLine();
                Regex r1 = new Regex("S");
                foreach (Match m in r1.Matches(g[i]))
                {
                    strawRows.Add(i);
                    strawColums.Add(m.Index);
                }
            }
            if (max)
            {
                int r = 0;
                for (int i = 0; i < g.Length; i++)
                {
                    if (!strawRows.Contains(i))
                    {
                        result += colums;
                        r++;
                    }
                }
                for (int i = 0; i < g[0].Length; i++)
                {
                    if (!strawColums.Contains(i))
                        result += (rows - r);
                }
            }
            else
            {
                int c = 0;
                for (int i = 0; i < g[0].Length; i++)
                {
                    if (!strawColums.Contains(i))
                    {
                        result += rows;
                        c++;
                    }
                }
                for (int i = 0; i < g.Length; i++)
                {
                    if (!strawRows.Contains(i))
                        result += (colums - c);
                }

            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
