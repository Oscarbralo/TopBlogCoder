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
            Decipher x = new Decipher();
            string[] a = { "RAZVLHAR KNW CNR",
  "HEA HNFMNSAR NFAK" };
            Console.WriteLine(x.decipher(a, "EORTPNFHSCDIWG"));
            Console.ReadLine();
        }
    }

    public class Decipher
    {
        public string[] decipher(string[] encoded, string frequencyOrder)
        {
            List<string> result = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < encoded.Length; i++)
            {
                string temp = encoded[i];
                for (int a = 0; a < temp.Length; a++)
                {
                    if (encoded[i][a] == ' ')
                        continue;
                    if (!dic.Keys.Contains(temp[a].ToString()))
                        dic.Add(temp[a].ToString(), 1);
                    else
                        dic[temp[a].ToString()] += 1;
                }
                dic = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, j => j.Value);

            }
            List<string> list = dic.Keys.Select(x => x).ToList();
            for (int i = 0; i < encoded.Length; i++)
            {
                for (int a = 0; a < encoded[i].Length; a++)
                {
                    int index = list.IndexOf(encoded[i][a].ToString());
                    if (index == -1)
                        continue;
                    encoded[i] = encoded[i].Insert(a, frequencyOrder[index].ToString());
                    encoded[i] = encoded[i].Remove(a + 1, 1);
                }
            }
            return encoded;
        }
    }
}
