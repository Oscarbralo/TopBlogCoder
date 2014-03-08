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
            ListeningIn x = new ListeningIn();
            Console.WriteLine(x.probableMatch("cptr", "capture"));
            Console.ReadLine();
        }
    }

    public class ListeningIn
    {
        public string probableMatch(string typed, string phrase)
        {
            if (typed == phrase)
                return string.Empty;
            if(typed.Length >= phrase.Length)
                return "UNMATCHED";
            List<string> phr = phrase.Select(x => x.ToString()).ToList();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < phr.Count; i++)
            {
                if (i == typed.Length)
                {
                    result.Append(string.Join("", phr.Skip(i).Take(phr.Count - i).ToArray<string>()));
                    phr = phr.Take(i).ToList();
                    break;
                }
                if(phr[i] != typed[i].ToString())
                {
                    result.Append(phr[i]);
                    phr.RemoveAt(i);
                    i--;
                }
            }
            string r1 = string.Join("", phr.ToArray<string>());
            if (r1 != typed)
                return "UNMATCHED";
            return result.ToString();
        }
    }
}
