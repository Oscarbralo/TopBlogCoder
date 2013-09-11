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
            BirthNumbersValidator x = new BirthNumbersValidator();
            string[] a = { "9702008690" };
            Console.WriteLine(x.validate(a));
            Console.ReadLine();
        }
    }

    public class BirthNumbersValidator
    {
        public string[] validate(string[] test)
        {
            string[] result = new string[test.Length];
            for (int i = 0; i < test.Length; i++)
            {
                string year = test[i].Substring(0,2);
                string month = test[i].Substring(2, 2);
                string day = test[i].Substring(4, 2);
                int m = int.Parse(month);
                int count = 0;
                if (m == 0)
                {
                    result[i] = "NO";
                    continue;
                }
                if (m > 12)
                    count++;
                if(m > 12 && m < 51 || m > 62)
                    count++;
                if (count == 2)
                {
                    result[i] = "NO";
                    continue;
                }
                int d = int.Parse(day);
                if (m > 62)
                {
                    result[i] = "NO";
                    continue;
                }
                else if(m > 12)
                    m -= 50;
                switch (m)
                {
                    case 1:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                    case 2:
                        if (int.Parse(year) % 4 == 0)
                        {
                            if (d < 1 || d > 29)
                                result[i] = "NO";
                        }
                        else
                        {
                            if (d < 1 || d > 28)
                                result[i] = "NO";
                        }
                        break;
                    case 3:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                    case 4:
                        if (d < 1 || d > 30)
                            result[i] = "NO";
                        break;
                    case 5:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                    case 6:
                        if (d < 1 || d > 30)
                            result[i] = "NO";
                        break;
                    case 7:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                    case 8:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                    case 9:
                        if (d < 1 || d > 30)
                            result[i] = "NO";
                        break;
                    case 10:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                    case 11:
                        if (d < 1 || d > 30)
                            result[i] = "NO";
                        break;
                    case 12:
                        if (d < 1 || d > 31)
                            result[i] = "NO";
                        break;
                }
                if (result[i] != null)
                    continue;
                if(long.Parse(test[i]) % 11 == 0)
                    result[i] = "YES";
                else
                    result[i] = "NO";
            }
            return result;
        }
    }
}
