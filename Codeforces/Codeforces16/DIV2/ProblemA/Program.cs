using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace A.Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            bool goodFlag = true;
            string strip = Console.ReadLine();
            string t = strip[0].ToString();
            if (strip.Count(x => x.ToString() != t) > 0)
            {
                Console.WriteLine("NO");
                goodFlag = false;
            }
            if (goodFlag)
            {
                for (int i = 1; i < int.Parse(input[0]); i++)
                {
                    string temp = Console.ReadLine();
                    string t1 = temp[0].ToString();
                    if (temp.Count(x => x.ToString() != t1) > 0 || t1 == t)
                    {
                        Console.WriteLine("NO");
                        goodFlag = false;
                    }
                    if (goodFlag == false)
                        break;
                    t = t1;
                }
                if(goodFlag)
                    Console.WriteLine("YES");
            }
            Console.ReadLine();
        }
    }
}
