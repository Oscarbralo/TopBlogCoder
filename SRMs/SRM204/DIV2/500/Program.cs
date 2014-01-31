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
            Aaagmnrs x = new Aaagmnrs();
            string[] a = { "s", "t" };
            Console.WriteLine(x.anagrams(a));
            Console.ReadLine();
        }
    }

    public class Aaagmnrs
    {
        public string[] anagrams(string[] phrases)
        {
            List<string> result = new List<string>();
            List<string> temp = phrases.ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                string inputA = temp[i].ToLower().Replace(" ", "");
                for (int a = i; a < temp.Count; a++)
                {
                    string inputB = temp[a].ToLower().Replace(" ", "");
                    if (a == i)
                        continue;
                    char[] t1 = inputA.ToCharArray();
                    Array.Sort(t1);
                    string tt1 = string.Join("", t1.Select(x => x.ToString()).ToArray<string>());
                    char[] t2 = inputB.ToLower().ToCharArray();
                    Array.Sort(t2);
                    string tt2 = string.Join("", t2.Select(x => x.ToString()).ToArray<string>());
                    var res = tt1.CompareTo(tt2);
                    if (res == 0)
                    {
                        if (!result.Contains(temp[i])) { result.Add(temp[i]); }
                        temp.RemoveAt(a);
                        a--;
                    }
                }
                if (!result.Contains(temp[i])) { result.Add(temp[i]); }
            }
            return result.ToArray();
        }
    }
}
