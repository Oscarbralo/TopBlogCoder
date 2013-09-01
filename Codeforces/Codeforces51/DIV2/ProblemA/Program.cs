using System;
using System.Collections.Generic;
using System.Text;

namespace A.Cheaterius_s_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < cases; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Console.ReadLine() + " " + Console.ReadLine());
                int count = 1;
                if (i != 0)
                {
                    while (count < 4)
                    {
                        if (!list.Contains(sb.ToString()))
                        {
                            string temp = sb.ToString()[3].ToString() +  sb.ToString()[0].ToString() + " " + sb.ToString()[4].ToString() + sb.ToString()[1].ToString();
                            sb.Clear();
                            sb.Append(temp);
                        }
                        else
                            break;
                        count++;
                    }
                    if(count == 4 && !list.Contains(sb.ToString()))
                        list.Add(sb.ToString());
                }
                else
                    list.Add(sb.ToString());
                string no = "";
                if (i < cases - 1)
                    no = Console.ReadLine();
            }
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}
