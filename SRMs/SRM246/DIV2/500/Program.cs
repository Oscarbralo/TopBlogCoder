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

    public class Conglutination
    {
        public string split(string conglutination, int expectation)
        {
            string res = "";
            for (int i = 1; i < conglutination.Length; i++)
            {
                string temp1 = conglutination.Substring(0, i);
                string temp2 = conglutination.Substring(i, conglutination.Length - i);
                string temp3 = temp2;
                while (temp3[0] == '0' && temp3.Length > 1)
                    temp3 = temp3.Remove(0, 1);
                if (temp1.Length > expectation.ToString().Length)
                    break;
                if (temp3.Length > expectation.ToString().Length)
                    continue;
                if (long.Parse(temp1) + long.Parse(temp3) == expectation)
                {
                    if (temp1 == "0")
                        continue;
                    res = temp1 + "+" + temp2;
                    break;
                }
            }
            return res;
        }
    }
}
