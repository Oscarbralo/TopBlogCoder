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

    public class Abacus
    {
        public string[] add(string[] original, int val)
        {
            string[] result = new string[6];
            string number = "";
            int[] num = new int[6];
            for (int i = 0; i < original.Length; i++)
            {
                int n = 0;
                int x = original[i].Length - 1;
                while (original[i][x] == 'o')
                {
                    n++;
                    x--;
                }
                number += n.ToString();
            }
            StringBuilder newNumber = new StringBuilder((int.Parse(number) + val).ToString());
            while (newNumber.Length < 6)
                newNumber.Insert(0, "0");
            for (int i = 0; i < newNumber.Length; i++)
                num[i] = int.Parse(newNumber[i].ToString());
            for (int i = 0; i < num.Length; i++)
            {
                StringBuilder sb = new StringBuilder("------------");
                int x = sb.Length - 1;
                int xx = 0;
                int begin = 9 - num[i];
                while (num[i] > 0)
                {
                    sb.Insert(x, "o");
                    sb.Remove(x + 1, 1);
                    x--;
                    num[i]--;
                }
                while (begin > 0)
                {
                    sb.Insert(xx, "o");
                    sb.Remove(xx + 1, 1);
                    xx++;
                    begin--;
                }
                result[i] = sb.ToString();
            }
            return result;
        }
    }
}
