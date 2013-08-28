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
            InboxCleanup x = new InboxCleanup();
            Console.WriteLine(x.fewestClicks("..........", 5, 10));
            Console.ReadLine();
        }
    }

    public class InboxCleanup
    {
        public int fewestClicks(string messages, int low, int high)
        {
            List<int> results = new List<int>();
            int count = low;
            for (int i = low; i <= high; i++)
            {
                List<string> list = splitLists(messages, i);
                int tempResult = 0;
                for (int a = 0; a < list.Count; a++)
                {
                    int half = list[a].Length / 2;
                    Regex r = new Regex("D");
                    int Ds = r.Matches(list[a]).Count;
                    if (Ds == 0)
                        tempResult += 0;
                    else if (Ds <= half)
                        tempResult += Ds + 1;
                    else
                        tempResult += 1 + 1 + (list[a].Length - Ds);
                    if(a != list.Count - 1)
                        tempResult++;
                }
                results.Add(tempResult);
            }
            int[] temp = results.ToArray();
            Array.Sort(temp);
            return temp[0];
        }

        public List<string> splitLists(string messages, int count)
        {
            List<string> list = new List<string>();
            while (messages.Length >= count)
            {
                if (messages.Length < count)
                    list.Add(messages.Substring(0, messages.Length));
                else
                {
                    list.Add(messages.Substring(0, count));
                    messages = messages.Remove(0, count);
                }
            }
            if (messages.Length > 0)
                list.Add(messages);
            return list;
        }
    }
}
