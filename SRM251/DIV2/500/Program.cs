using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SMS
    {
        public string compress(string originalMessage)
        {
            string pattern = @"[aeiouAEIOU]";
            Regex r = new Regex(pattern);
            List<string> list = new List<string>();
            foreach (string s in originalMessage.Split(' '))
            {
                if (s != "")
                    list.Add(s);
            }
            for (int i = 0; i < list.Count; i++)
            {
                string t1 = list[i];
                int x = r.Matches(list[i]).Count;
                if (x != list[i].Length)
                {
                    int j = 0;
                    string temp = "";
                    string temp1 = "";
                    List<string> values = new List<string>();
                    List<int> indices = new List<int>();
                    foreach (Match m in r.Matches(list[i]))
                    {
                        values.Add(m.Value);
                        indices.Add(m.Index);
                    }
                    for (int b = 0; b < indices.Count; b++)
                    {
                        if (indices[b] == j)
                        {
                            temp1 += values[b];
                            j++;
                        }
                    }
                    j = list[i].Length - 1;
                    for (int a = indices.Count - 1; a >= 0; a--)
                    {
                        if (indices[a] == j)
                        {
                            temp = temp.Insert(0, values[a]);
                            j--;
                        }
                    }
                    for (int a = 0; a < values.Count; a++)
                        list[i] = list[i].Replace(values[a], "");
                    list[i] = list[i].Insert(list[i].Length, temp);
                    list[i] = list[i].Insert(0, temp1);
                    originalMessage = originalMessage.Replace(t1, list[i]);
                }
            }
            return originalMessage;
        }
    }
}
