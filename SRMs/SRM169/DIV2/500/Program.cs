using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            Twain x = new Twain();
            Console.WriteLine(x.getNewSpelling(7, "sch kn x xschrx cknnchc cyck xxceci"));
            Console.ReadLine();
        }
    }

    public class Twain
    {
        public string getNewSpelling(int year, string phrase)
        {
            Years y = new Years();
            if (year == 0)
                return phrase;
            string[] p = phrase.Split(' ');
            switch (year)
            {
                case 1:
                    y.Year1(p);
                    break;
                case 2:
                    y.Year1(p);
                    y.Year2(p);
                    break;
                case 3:
                    y.Year1(p);
                    y.Year2(p);
                    y.Year3(p);
                    break;
                case 4:
                    y.Year1(p);
                    y.Year2(p);
                    y.Year3(p);
                    y.Year4(p);
                    break;
                case 5:
                    y.Year1(p);
                    y.Year2(p);
                    y.Year3(p);
                    y.Year4(p);
                    y.Year5(p);
                    break;
                case 6:
                    y.Year1(p);
                    y.Year2(p);
                    y.Year3(p);
                    y.Year4(p);
                    y.Year5(p);
                    y.Year6(p);
                    break;
                case 7:
                    y.Year1(p);
                    y.Year2(p);
                    y.Year3(p);
                    y.Year4(p);
                    y.Year5(p);
                    y.Year6(p);
                    y.Year7(p);
                    break;
            }
            string result = "";
            for (int i = 0; i < p.Length; i++)
            {
                result += p[i] + " ";
            }
            result = result.Remove(result.Length - 1, 1);
            return result;
        }

        public class Years
        {
            public string[] Year1(string[] p)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i].StartsWith("x"))
                    {
                        p[i] = p[i].Insert(0, "z");
                        p[i] = p[i].Remove(1, 1);
                    }
                    if (p[i].Contains("x"))
                        p[i] = p[i].Replace("x", "ks");
                }
                return p;
            }

            public string[] Year2(string[] p)
            {
                for (int i = 0; i < p.Length; i++)
                    p[i] = p[i].Replace("y", "i");
                return p;
            }

            public string[] Year3(string[] p)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i].Contains("ce"))
                        p[i] = p[i].Replace("ce", "se");
                    if (p[i].Contains("ci"))
                        p[i] = p[i].Replace("ci", "si");
                }
                return p;
            }

            public string[] Year4(string[] p)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    while (p[i].Contains("ck"))
                    {
                        for (int b = 0; b < p[i].Length; b++)
                        {
                            if (p[i][b] == 'c')
                            {
                                if (b == p[i].Length - 1)
                                    continue;
                                else if (p[i][b + 1] == 'k')
                                    p[i] = p[i].Remove(b, 1);
                            }
                        }
                    }
                }
                return p;
            }

            public string[] Year5(string[] p)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i].StartsWith("sch"))
                    {
                        p[i] = p[i].Remove(1, 2);
                        p[i] = p[i].Insert(1, "k");
                    }
                    while (p[i].Contains("chr"))
                    {
                        for (int b = 0; b < p[i].Length; b++)
                        {
                            if (p[i][b] == 'c')
                            {
                                if (p[i][b + 1] == 'h')
                                {
                                    p[i] = p[i].Insert(b, "k");
                                    p[i] = p[i].Remove(b + 1, 2);
                                }
                            }
                        }
                    }
                    for (int c = 0; c < p[i].Length; c++)
                    {
                        if (p[i][c] == 'c')
                        {
                            if (c == p[i].Length - 1)
                            {
                                p[i] = p[i].Insert(c, "k");
                                p[i] = p[i].Remove(c + 1, 1);
                            }
                            else if (p[i][c + 1] != 'h')
                            {
                                p[i] = p[i].Insert(c, "k");
                                p[i] = p[i].Remove(c + 1, 1);
                            }
                        }
                    }
                }
                return p;
            }

            public string[] Year6(string[] p)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i].StartsWith("kn"))
                        p[i] = p[i].Remove(0, 1);
                }
                return p;
            }

            public string[] Year7(string[] p)
            {
                string res = "";
                string temp = "";
                for (int i = 0; i < p.Length; i++)
                {
                    res = "";
                    for (int a = 0; a < p[i].Length; a++)
                    {
                        temp = p[i][a].ToString();
                        if (p[i][a] != 'a' && p[i][a] != 'e' && p[i][a] != 'i' && p[i][a] != 'o' && p[i][a] != 'u' || res == "")
                        {
                            if (res == "")
                                res += temp;
                            else if (res[res.Length - 1].ToString() != temp)
                                res += temp;
                        }
                        else
                            res += temp;
                    }
                    p[i] = res;
                }
                return p;
            }
        }
    }
}
