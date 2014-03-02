using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _400
{
    class Program
    {
        static void Main(string[] args)
        {
            Conglutination x = new Conglutination();
            Console.WriteLine(x.split("10000000000000000000", 1));
            Console.ReadLine();
        }
    }

    public class Conglutination
    {
        public string split(string conglutination, int expectation)
        {
            string result = "-1";
            for (int i = 1; i < conglutination.Length; i++)
            {
                string left = string.Join("", conglutination.Take(i));
                string right = string.Join("", conglutination.Skip(i).Take(conglutination.Length - i));
                if ((left.Length > 18 || right.Length > 18) && (right[0] == '9' || left[0] == '9')) continue;
                result = (long.Parse(left) + long.Parse(right) == expectation) ? string.Format("{0}+{1}", left, right) : "-1";
                if (result != "-1") break;
            }
            return result == "-1" ? string.Empty : result;
        }
    }
}
