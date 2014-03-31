using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("zero", "0");
                dic.Add("one", "1");
                dic.Add("two", "2");
                dic.Add("three", "3");
                dic.Add("four", "4");
                dic.Add("five", "5");
                dic.Add("six", "6");
                dic.Add("seven", "7");
                dic.Add("eight", "8");
                dic.Add("nine", "9");
                StringBuilder sb = new StringBuilder();
                line.Split(';').ToList().ForEach(x => sb.Append(dic[x]));
                Console.WriteLine(sb.ToString());
            }
    }
}