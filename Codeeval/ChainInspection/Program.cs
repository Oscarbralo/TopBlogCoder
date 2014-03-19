using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                string[] temp = line.Split(';');
                for (int i = 0; i < temp.Length; i++)
                {
                    string[] t = temp[i].Split('-');
                    dic.Add(t[0], t[1]);
                }
                dic = dic.OrderByDescending(x => x.Key == "BEGIN").ToDictionary(x => x.Key, x => x.Value);
                bool finish = false;
                string next = dic["BEGIN"];
                int count = 1;
                for (int i = 0; i < dic.Count; i++)
                {
                    if (next == "END")
                    {
                        finish = true;
                        break;
                    }
                    if (dic.ContainsKey(next))
                    {
                        next = dic[next];
                    }
                    else
                    {
                        finish = false;
                        break;
                    }
                    count++;
                }
                Console.WriteLine(finish && count == dic.Count ? "GOOD" : "BAD");
            }
    }
}