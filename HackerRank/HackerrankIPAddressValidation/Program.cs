using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution
{
    static void Main(String[] args)
    {
        string abc = "abcd";
        int cases = int.Parse(Console.ReadLine());
        Regex r = new Regex(@":");
        Regex r1 = new Regex(@"[0-9]");
        for (int a = 0; a < cases; a++)
        {
            string temp = Console.ReadLine();
            if (temp.Contains(" "))
            {
                Console.WriteLine("Neither");
                continue;
            }
            string[] v = temp.Split('.');
            if (v.Length == 4)
            {
                bool finish = true;
                for (int i = 0; i < v.Length; i++)
                {
                    if (int.Parse(v[i]) > 255)
                        finish = false;
                }
                if (finish)
                    Console.WriteLine("IPv4");
                else
                    Console.WriteLine("Neither");
            }
            else if (r.Matches(temp).Count == 7)
            {
                int c1 = r1.Matches(temp.Substring(temp.Length - 4, 4)).Count;
                if (c1 == 4 || abc.Contains(temp[temp.Length - 1].ToString()))
                    Console.WriteLine("IPv6");
                else
                    Console.WriteLine("Neither");
            }
            else
                Console.WriteLine("Neither");
        }
    }
}