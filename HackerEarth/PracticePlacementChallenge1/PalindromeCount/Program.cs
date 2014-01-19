using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PalindromeCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> list = new List<string>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                int x = 1;
                while (x <= text.Length - i)
                {
                    list.Add(text.Substring(i, x));
                    x++;
                }
            }
            list.Add(text[text.Length - 1].ToString());
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length == 1)
                    result++;
                else
                {
                    bool finish = true;
                    int end = list[i].Length - 1;
                    for (int a = 0; a < list[i].Length / 2; a++)
                    {
                        if (list[i][a] != list[i][end])
                        {
                            finish = false;
                            break;
                        }
                        end--;
                    }
                    if (finish)
                        result++;
                }
            }
            Console.ReadLine();
        }
    }
}
