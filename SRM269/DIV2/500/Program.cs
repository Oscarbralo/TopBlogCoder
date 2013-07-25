using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PatternOptimizer
    {
        public string optimize(string pattern)
        {
            for (int i = 1; i < pattern.Length; i++)
            {
                if (pattern[i] == '*')
                {
                    int a = i - 1;
                    while (pattern[a] == '?' || pattern[a] == '*')
                    {
                        pattern = pattern.Insert(a, "*");
                        pattern = pattern.Remove(a + 2, 1);
                        if (a == 0)
                            break;
                        a--;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '*')
                {
                    if (result == "")
                        result += "*";
                    else if (!result.EndsWith("*"))
                        result += "*";
                }
                else
                    result += pattern[i].ToString();
            }
            return result;
        }
    }
}
