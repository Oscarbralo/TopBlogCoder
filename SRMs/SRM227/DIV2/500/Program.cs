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
            ClientsList x = new ClientsList();
            string[] a = { "Joe Smith", "Brown, Sam", "Miller, Judi" };
            Console.WriteLine(x.dataCleanup(a));
            Console.ReadLine();
        }
    }

    public class ClientsList
    {
        public string[] dataCleanup(string[] names)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains(','))
                {
                    string[] t = names[i].Split(' ').Select(x => x.Replace(",", "")).ToArray<string>();
                    string temp = t[1] + " " + t[0];
                    list.Add(temp);
                }
                else
                    list.Add(names[i]);
            }
            return list.OrderBy(x => x.Split(' ')[1]).ThenBy(x => x.Split(' ')[0]).ToArray<string>();
        }
    }
}
