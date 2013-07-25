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

    public class PalindromeMaker
    {
        public string make(string baseString)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] abcTotal = new int[abc.Length];
            for (int i = 0; i < baseString.Length; i++)
                abcTotal[abc.IndexOf(baseString[i].ToString())]++;
            string begin = "";
            string end = "";
            for (int i = 0; i < abcTotal.Length; i++)
            {
                while (abcTotal[i] > 1 && abcTotal[i] != 0)
                {
                    begin += abc[i];
                    end = end.Insert(0, abc[i].ToString());
                    abcTotal[i] -= 2;
                }
            }
            for (int i = 0; i < abcTotal.Length; i++)
            {
                if (abcTotal[i] != 0)
                {
                    begin += abc[i];
                    break;
                }
            }
            bool res = (begin.Length + end.Length == baseString.Length) ? true : false;
            if (res)
                return begin + end;
            else
                return "";
        }
    }
}
