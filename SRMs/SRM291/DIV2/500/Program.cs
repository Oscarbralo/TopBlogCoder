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
            Snowflakes x = new Snowflakes();
            string[] a = {".",
 "..",
 "***",
 "...."};
            Console.WriteLine(x.flareOut(a));
            Console.ReadLine();
        }
    }

    public class Snowflakes
    {
        public string[] flareOut(string[] snowflake)
        {
            string[] reverse = new string[snowflake.Length * 2];
            for (int i = 0; i < snowflake.Length; i++)
            {
                for (int a = i + 1; a < snowflake.Length; a++)
                {
                    snowflake[i] += snowflake[a][i].ToString();
                }
            }
            int j = 0;
            int jj = reverse.Length - 1;
            for (int i = snowflake.Length - 1; i >= 0; i--)
            {
                reverse[j] = snowflake[i];
                reverse[jj] = snowflake[i];
                j++;
                jj--;
            }
            for (int i = 0; i < reverse.Length; i++)
                reverse[i] = string.Join("", reverse[i].Reverse().Select(x => x.ToString()).ToArray<string>()) + reverse[i];
            return reverse;
        }
    }
}
