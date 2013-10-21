using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int lines = int.Parse(Console.ReadLine());
        Regex r1 = new Regex(@"(<){1}\s{0,}[a-zA-Z0-9]{1,}\s{0,1}");
        List<string> list = new List<string>();
        for (int i = 0; i < lines; i++)
        {
            string line = Console.ReadLine();
            foreach (Match m in r1.Matches(line))
            {
                string temp = m.Value.Replace("<", "");
                temp = temp.Replace(">", "");
                temp = temp.Replace(" ", "");
                if (!list.Contains(temp))
                    list.Add(temp);
            }
        }
        string[] res = list.ToArray();
        Array.Sort(res);
        string result = "";
        for (int i = 0; i < res.Length; i++)
            result += res[i].ToString() + ";";
        result = result.Remove(result.Length - 1, 1);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}