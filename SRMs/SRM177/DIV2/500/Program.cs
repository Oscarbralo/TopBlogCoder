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
            OldestOne x = new OldestOne();
            string[] a = { "DOUG JONES 22 213 ALDEN LANE", "   BOB     A SMITH  102 CLARK ST" };
            Console.WriteLine(x.oldest(a));
            Console.ReadLine();
        }
    }

    public class OldestOne
    {
        public string oldest(string[] data)
        {
            string result = "";
            int oldest = 0;
            Regex r = new Regex(@"[ ]{1,}[0-9]{1,}[ ]{1,}");
            for (int i = 0; i < data.Length; i++)
            {
                int temp = int.Parse(r.Match(data[i]).Value.Trim().ToString());
                if (temp > oldest)
                {
                    oldest = temp;
                    result = data[i].Substring(0, r.Match(data[i]).Index);
                    while (result.StartsWith(" "))
                        result = result.Remove(0, 1);
                }
            }
            return result;
        }
    }
}
