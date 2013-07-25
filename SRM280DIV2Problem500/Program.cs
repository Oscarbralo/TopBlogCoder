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

    public class CompletingBrackets
    {
        public string complete(string text)
        {
            string t = text;
            StringBuilder sb = new StringBuilder(text);
            sb.Append(".");
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '[' && sb[i + 1] == ']')
                {
                    sb.Remove(i, 2);
                    if (i == 0)
                        i--;
                    else
                        i -= 2;
                }
            }
            if (sb.ToString() == ".")
                return t;
            else
            {
                int left = 0;
                int right = 0;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == '[')
                        right++;
                    else if (sb[i] == '.')
                        sb.Remove(i, 1);
                    else
                        left++;
                }
                sb = new StringBuilder(t);
                for (int i = 0; i < left; i++)
                    sb.Insert(0, "[");
                for (int i = 0; i < right; i++)
                    sb.Append("]");
            }
            return sb.ToString();
        }
    }
}
