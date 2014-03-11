using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] numbers = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M", "MM", "MMM" };
                int a = 1;
                StringBuilder sb = new StringBuilder();
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    string t = line.Substring(i, 1);
                    int t1 = int.Parse(t) * a;
                    if (t1 < 10 && t1 > 0)
                        sb.Insert(0, numbers[t1 - 1]);
                    if (t1 >= 10 && t1 < 100)
                        sb.Insert(0, numbers[9 + (int.Parse(t) - 1)]);
                    if (t1 >= 100 && t1 < 1000)
                        sb.Insert(0, numbers[18 + (int.Parse(t) - 1)]);
                    if (t1 >= 1000)
                        sb.Insert(0, numbers[27 + (int.Parse(t) - 1)]);
                    a *= 10;
                }
                Console.WriteLine(sb.ToString());
            }
    }
}
