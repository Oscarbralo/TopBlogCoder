using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace HiddenDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "abcdefghik";
            string abc = "abcdefghij";
            string num = "0123456789";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                if (abc.Contains(line[i]))
                    sb.Append(num[abc.IndexOf(line[i])]);
                else if (num.Contains(line[i]))
                    sb.Append(line[i]);
            }
            Console.WriteLine(string.IsNullOrEmpty(sb.ToString()) ? "NONE" : sb.ToString());
            Console.ReadLine();
        }
    }
}
