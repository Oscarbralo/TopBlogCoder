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
            IndicatorMotionReverse x = new IndicatorMotionReverse();
            string[] a = { "||||||||||||||||||||||||||||||||||||||||N-/|N-/|N-", "/|N-/|N-/|/-N|/-N|/-N|/-N|/-N|/-N|/-N-/|N-/|N-/|N-", "/|N-/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/NNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNN/N/N/N/N/N/N/N/N/N/N/N/N", "/N/N/N////////N/N/N/N/N/N/N/N/N/N/N/N/N/N|/-N|/-N|", "/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N/N/N/N/N/N/", "N/N/N/N/N/N/N/N/N/N/-N|/-N|/-N|/-N|/-N|/-N|-------", "------N|/-N|/-N|/-N|/-N|/-N|/-N|/N/N/N/N//////////", "///////////////////////////|N-/|N-/|N-/|N-/|N-/|N-", "/|N-/|N-/|N-/|N-/|N|/-N|/-N|/-N|/-N|/-N|/-N|/-/-N|", "/-N|/-N|/-N|//////////////////////////////////////", "///N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N/N-/|N-/|N-/|N|/", "-N|/-N|/-N|/-N|/-/|N-/|N-/|N-/|N-/|N-/|N-/|N-/|N-/", "|N-/|N-/|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/----", "-/|N-/|N-/|N-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N|/-N", "|/-N|/-N|/|N-/|N-/|N-/|N-/|N-/|N-/|N-/|N-/|N-/|N-/", "|N|/-N|/-N|/|N-/|N-/|N-/" };
            Console.WriteLine(x.getMinProgram(a));
            Console.ReadLine();
        }
    }

    public class IndicatorMotionReverse
    {
        public string getMinProgram(string[] actions)
        {
            string text = string.Join("", actions);
            List<string> list = new List<string>();
            list.Add("N");
            list.Add("|");
            list.Add("/");
            list.Add("-");
            List<string> results = new List<string>();
            if (text.Length == 1)
                Console.WriteLine(string.Empty);
            else
            {
                string now = string.Empty;
                int temp = 0;
                int lastAction = 0;
                for (int i = 1; i < text.Length; i++)
                {
                    int last = list.IndexOf(text[i - 1].ToString());
                    int current = list.IndexOf(text[i].ToString());
                    int res = current - last;
                    if (res == 0)
                    {
                        if (now == "S" || string.IsNullOrEmpty(now))
                        {
                            temp++;
                            if (temp == 99)
                            {
                                results.Add(string.Format("{0}{1}", now, temp.ToString()));
                                temp = 0;
                                lastAction = 99;
                            }
                            if (string.IsNullOrEmpty(now))
                                now = "S";
                        }
                        else
                        {
                            if (temp != 0)
                            {
                                if (lastAction == 99)
                                {
                                    int t1 = results.Count;
                                    while (int.Parse(results[t1 - 1].Substring(1, 2)) == 99 && results[t1 - 1][0].ToString() == now)
                                    {
                                        t1--;
                                        if (t1 == 0)
                                            break;
                                    }
                                    string t2 = results[t1];
                                    string final = string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString()));
                                    results[t1] = final;
                                    results.Add(t2);
                                }
                                else
                                {
                                    results.Add(string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString())));
                                }
                            }
                            lastAction = temp;
                            temp = 1;
                            now = "S";
                        }
                    }
                    else if (res == 1 || res == -3)
                    {
                        if (now == "R" || string.IsNullOrEmpty(now))
                        {
                            temp++;
                            if (temp == 99)
                            {
                                results.Add(string.Format("{0}{1}", now, temp.ToString()));
                                temp = 0;
                                lastAction = 99;
                            }
                            if (string.IsNullOrEmpty(now))
                                now = "R";
                        }
                        else
                        {
                            if (temp != 0)
                            {
                                if (lastAction == 99)
                                {
                                    int t1 = results.Count;
                                    while (int.Parse(results[t1 - 1].Substring(1, 2)) == 99 && results[t1 - 1][0].ToString() == now)
                                    {
                                        t1--;
                                        if (t1 == 0)
                                            break;
                                    }
                                    string t2 = results[t1];
                                    string final = string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString()));
                                    results[t1] = final;
                                    results.Add(t2);
                                }
                                else
                                {
                                    results.Add(string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString())));
                                }
                            }
                            lastAction = temp;
                            temp = 1;
                            now = "R";
                        }
                    }
                    else if (res == -1 || res == 3)
                    {
                        if (now == "L" || string.IsNullOrEmpty(now))
                        {
                            temp++;
                            if (temp == 99)
                            {
                                results.Add(string.Format("{0}{1}", now, temp.ToString()));
                                temp = 0;
                                lastAction = 99;
                            }
                            if (string.IsNullOrEmpty(now))
                                now = "L";
                        }
                        else
                        {
                            if (temp != 0)
                            {
                                if (lastAction == 99)
                                {
                                    int t1 = results.Count;
                                    while (int.Parse(results[t1 - 1].Substring(1, 2)) == 99 && results[t1 - 1][0].ToString() == now)
                                    {
                                        t1--;
                                        if (t1 == 0)
                                            break;
                                    }
                                    string t2 = results[t1];
                                    string final = string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString()));
                                    results[t1] = final;
                                    results.Add(t2);
                                }
                                else
                                {
                                    results.Add(string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString())));
                                }
                            }
                            lastAction = temp;
                            temp = 1;
                            now = "L";
                        }
                    }
                    else if (res == 2 || res == -2)
                    {
                        if (now == "F" || string.IsNullOrEmpty(now))
                        {
                            temp++;
                            if (temp == 99)
                            {
                                results.Add(string.Format("{0}{1}", now, temp.ToString()));
                                temp = 0;
                                lastAction = 99;
                            }
                            if (string.IsNullOrEmpty(now))
                                now = "F";
                        }
                        else
                        {
                            if (temp != 0)
                            {
                                if (lastAction == 99)
                                {
                                    int t1 = results.Count;
                                    while (int.Parse(results[t1 - 1].Substring(1, 2)) == 99 && results[t1 - 1][0].ToString() == now)
                                    {
                                        t1--;
                                        if (t1 == 0)
                                            break;
                                    }
                                    string t2 = results[t1];
                                    string final = string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString()));
                                    results[t1] = final;
                                    results.Add(t2);
                                }
                                else
                                {
                                    results.Add(string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString())));
                                }
                            }
                            lastAction = temp;
                            temp = 1;
                            now = "F";
                        }
                    }
                }
                if (temp != 0)
                {
                    if (lastAction == 99)
                    {
                        int t1 = results.Count;
                        while (int.Parse(results[t1 - 1].Substring(1, 2)) == 99 && results[t1 - 1][0].ToString() == now)
                        {
                            t1--;
                            if (t1 == 0)
                                break;
                        }
                        string final = string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString()));
                        results[t1] = final;
                        results.Add(string.Format("{0}99", now));
                    }
                    else
                    {
                        results.Add(string.Format("{0}{1}{2}", now, temp < 10 ? 0 : int.Parse(temp.ToString()[0].ToString()), temp >= 10 ? int.Parse(temp.ToString()[1].ToString()) : int.Parse(temp.ToString()[0].ToString())));
                    }
                }
            }
            string result = string.Join("", results.ToArray<string>());
            return result.Length > 100 ? string.Format("{0}...", result.Substring(0, 97)) : result;
        }
    }
}
