using System;
using System.Collections.Generic;

namespace B.President_s_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] lines = new string[int.Parse(input[0])];
            List<string> list = new List<string>();
            list.Add(input[2]);
            int result = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();
            }
            for (int i = 0; i < lines.Length; i++)
            {
                for (int a = 0; a < lines[i].Length; a++)
                {
                    string temp = lines[i][a].ToString();
                    if (temp == input[2])
                    {
                        if (i - 1 >= 0)
                        {
                            temp = lines[i - 1][a].ToString();
                            if (!list.Contains(temp) && temp != ".")
                            {
                                list.Add(temp);
                                result++;
                            }
                        }
                        if (i + 1 < lines.Length)
                        {
                            temp = lines[i + 1][a].ToString();
                            if (!list.Contains(temp) && temp != ".")
                            {
                                list.Add(temp);
                                result++;
                            }
                        }
                        if (a - 1 >= 0)
                        {
                            temp = lines[i][a - 1].ToString();
                            if (!list.Contains(temp) && temp != ".")
                            {
                                list.Add(temp);
                                result++;
                            }
                        }
                        if (a + 1 < lines[i].Length)
                        {
                            temp = lines[i][a + 1].ToString();
                            if (!list.Contains(temp) && temp != ".")
                            {
                                list.Add(temp);
                                result++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
