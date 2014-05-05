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
            Abacus x = new Abacus();
            string[] a = { "ooooooooo---", "---ooooooooo", "ooooooooo---", "---ooooooooo", "oo---ooooooo", "---ooooooooo" };
            Console.WriteLine(x.add(a, 6));
            Console.ReadLine();
        }
    }

    public class Abacus
    {
        public string[] add(string[] original, int val)
        {
            int number = ConvertToInt(original);
            string n = (number + val).ToString();
            while (n.Length < 6)
                n = n.Insert(0, "0");
            original = ConvertToAbacus(n);
            return original;
        }

        public int ConvertToInt(string[] abacus)
        {
            int result = 0;
            int temp = 100000;
            for (int i = 0; i < abacus.Length; i++)
            {
                string[] abacusTemp = abacus[i].Split('-');
                for (int a = 1; a < abacusTemp.Length; a++)
                {
                    if (!string.IsNullOrEmpty(abacusTemp[a]))
                        result += abacusTemp[a].Length * temp;
                }
                temp /= 10;
            }
            return result;
        }

        public string[] ConvertToAbacus(string number)
        {
            string[] abacus = new string[6];
            for (int i = 0; i < number.Length; i++)
            {
                int n = int.Parse(number[i].ToString());
                int left = 9 - n;
                StringBuilder sb = new StringBuilder();
                while (left > 0)
                {
                    sb.Append("o");
                    left--;
                }
                sb.Append("---");
                while (n > 0)
                {
                    sb.Append("o");
                    n--;
                }
                abacus[i] = sb.ToString();
            }
            return abacus;
        }
    }
}
