using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            CompletingBrackets x = new CompletingBrackets();
            Console.WriteLine(x.complete("[["));
            Console.ReadLine();
        }
    }

    public class CompletingBrackets
    {
        public string complete(string text)
        {
            List<string> lefts = text.Select(x => x.ToString()).ToList();
            List<string> rights = text.Select(x => x.ToString()).ToList();
            for (int i = 0; i < lefts.Count - 1; i++)
            {
                if (lefts[i] == "[")
                {
                    for (int a = i + 1; a < lefts.Count; a++)
                    {
                        if (lefts[a] == "]")
                        {
                            lefts.RemoveAt(a);
                            lefts.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
            }
            for (int i = rights.Count - 1; i > 0; i--)
            {
                if (rights[i] == "]")
                {
                    for (int a = i - 1; a >= 0; a--)
                    {
                        if (rights[a] == "[")
                        {
                            rights.RemoveAt(i);
                            rights.RemoveAt(a);
                            i--;
                            break;
                        }
                    }
                }
            }
            int left = lefts.Count(x => x == "[");
            int right = rights.Count(x => x == "]");
            StringBuilder sb = new StringBuilder(text);
            while (left > 0)
            {
                sb.Append("]");
                left--;
            }
            while (right > 0)
            {
                sb = sb.Insert(0, "[");
                right--;
            }
            return sb.ToString();
        }
    }
}
