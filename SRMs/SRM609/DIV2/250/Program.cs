using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicalStringDiv2 x = new MagicalStringDiv2();
            Console.WriteLine(x.minimalMoves(">><<><"));
            Console.ReadLine();
        }
    }

    public class MagicalStringDiv2
    {
        public int minimalMoves(string S)
        {
            string split1 = S.Substring(0, S.Length / 2);
            string split2 = S.Substring(S.Length / 2, S.Length / 2);
            int split1Left = split1.Count(x => x == '<');
            int split2Right = split2.Count(x => x == '>');
            return split1Left + split2Right;
        }
    }
}
