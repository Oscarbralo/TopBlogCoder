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

    public class CmpdWords
    {
        public int ambiguous(string[] dictionary)
        {
            List<string> list = new List<string>();
            List<int> count = new List<int>();
            int res = 0;
            for (int a = 0; a < dictionary.Length; a++)
            {
                if (!list.Contains(dictionary[a]))
                {
                    list.Add(dictionary[a]);
                    count.Add(1);
                }
                else
                    count[list.IndexOf(dictionary[a])]++;
                for (int b = 0; b < dictionary.Length; b++)
                {
                    string temp = dictionary[a] + dictionary[b];
                    if (a == b)
                        continue;
                    if (!list.Contains(temp))
                    {
                        list.Add(temp);
                        count.Add(1);
                    }
                    else
                        count[list.IndexOf(temp)]++;
                }
            }
            for (int c = 0; c < count.Count; c++)
            {
                if (count[c] > 1)
                    res++;
            }
            return res;
        }
    }
}
