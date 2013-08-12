using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AJourneyToTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int result = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                bool fini = false;
                for (int a = 0; a < list.Count; a++)
                {
                    if (list[a].Contains(temp[0]) || list[a].Contains(temp[1]))
                    {
                        if (list[a].Contains(temp[0]))
                            list[a] += temp[1];
                        else
                            list[a] += temp[0];
                        fini = true;
                        break;
                    }
                }
                if (fini == false)
                {
                    list.Add(temp[0]);
                    list[list.Count - 1] += temp[1];
                }
            }
            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                bool fin = false;
                for (int a = 0; a < list.Count; a++)
                {
                    if (list[a].Contains(i.ToString()))
                    {
                        fin = true;
                        break;
                    }
                }
                if (fin == false)
                    list.Add(i.ToString());
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int a = i + 1; a < list.Count; a++)
                {
                    result += list[i].Length * list[a].Length;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
