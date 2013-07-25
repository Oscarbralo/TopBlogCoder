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

    public class Snowflakes
    {
        public string[] flareOut(string[] snowflake)
        {
            string[] temp = new string[snowflake.Length];
            for (int i = 0; i < snowflake[snowflake.Length - 1].Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int a = snowflake.Length - 1; a > i; a--)
                {
                    sb.Insert(0, snowflake[a][i].ToString());
                }
                if (sb.ToString() == "")
                    temp[i] = snowflake[i];
                else
                {
                    sb.Insert(0, snowflake[i]);
                    temp[i] = sb.ToString();
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int a = temp[i].Length - 1; a >= 0; a--)
                    sb.Append(temp[i][a].ToString());
                sb.Append(temp[i]);
                temp[i] = sb.ToString();
            }
            string[] result = new string[temp.Length * 2];
            int x = -1;
            for (int i = temp.Length - 1; i >= 0; i--)
                result[++x] = temp[i];
            for (int i = 0; i < temp.Length; i++)
                result[++x] = temp[i];
            return result;
        }
    }
}
