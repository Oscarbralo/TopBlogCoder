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
            XBallGame x = new XBallGame();
            string[] a = {"John-DH", 
 "Jack-SP", 
 "Sam-OF", 
 "John-SP", 
 "John-RP"};
            Console.WriteLine(x.newStatistics(a));
            Console.ReadLine();
        }
    }

    public class XBallGame
    {
        public string[] newStatistics(string[] placeboard)
        {
            string[] result = new string[placeboard.Length];
            for (int i = 0; i < placeboard.Length; i++)
            {
                List<string> n = new List<string>();
                StringBuilder names = new StringBuilder();
                names.Append(placeboard[i]);
                string[] temp = placeboard[i].Split('-');
                for (int a = 0; a < placeboard.Length; a++)
                {
                    if (a == i)
                        continue;
                    string[] temp1 = placeboard[a].Split('-');
                    if (temp[0] == temp1[0])
                        n.Add(temp1[1]);
                }
                string[] name = n.ToArray();
                Array.Sort(name);
                for (int b = 0; b < name.Length; b++)
                    names.Append("," + name[b]);
                result[i] = names.ToString();
            }
            return result;
        }
    }
}
