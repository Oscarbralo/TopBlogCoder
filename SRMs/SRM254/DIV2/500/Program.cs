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

    public class ListeningIn
    {
        public string probableMatch(string typed, string phrase)
        {
            if (typed == phrase)
                return "";
            for (int a = 0; a < phrase.Length; a++)
            {
                if (typed.Length < 1)
                    break;
                if (phrase[a] == typed[0])
                {
                    typed = typed.Remove(0, 1);
                    phrase = phrase.Remove(a, 1);
                    a--;
                    continue;
                }
            }
            if (typed.Length > 0)
                return "UNMATCHED";
            return phrase;
        }
    }
}
