using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\GCJ\A-small-attempt0.in");
            StreamWriter sw = new StreamWriter(@"C:\GCJ\A-Output.txt");
            string line = string.Empty;
            int cases = int.Parse(sr.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int answerFirst = int.Parse(sr.ReadLine()) - 1;
                string[] firstBoard = new string[4];
                for (int a = 0; a < 4; a++)
                {
                    firstBoard[a] = sr.ReadLine();
                }
                int secondFirst = int.Parse(sr.ReadLine()) - 1;
                string[] secondBoard = new string[4];
                for (int a = 0; a < 4; a++)
                {
                    secondBoard[a] = sr.ReadLine();
                }
                List<int> list = new List<int>();
                int[] firstRow = firstBoard[answerFirst].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                int[] secondRow = secondBoard[secondFirst].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                for (int a = 0; a < firstRow.Length; a++)
                {
                    if (secondRow.Contains(firstRow[a]))
                        list.Add(firstRow[a]);
                }
                if (list.Count == 0)
                    sw.WriteLine(string.Format("Case #{0}: {1}", i + 1, "Volunteer cheated!"));
                if (list.Count == 1)
                    sw.WriteLine(string.Format("Case #{0}: {1}", i + 1, list[0]));
                if (list.Count > 1)
                    sw.WriteLine(string.Format("Case #{0}: {1}", i + 1, "Bad magician!"));
            }
            sr.Close();
            sw.Close();
        }
    }
}
