using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Decipher
    {
        public string[] decipher(string[] encoded, string frequencyOrder)
        {
            List<string> abc = new List<string>();
            List<int> total = new List<int>();
            List<string> temp = new List<string>();
            for (int i = 0; i < encoded.Length; i++)
            {
                for (int a = 0; a < encoded[i].Length; a++)
                {
                    if (!abc.Contains(encoded[i][a].ToString()) && encoded[i][a] != ' ')
                    {
                        abc.Add(encoded[i][a].ToString());
                        total.Add(1);
                    }
                    else
                    {
                        if (encoded[i][a] != ' ')
                            total[abc.IndexOf(encoded[i][a].ToString())]++;
                    }
                }
            }
            int x = frequencyOrder.Length;
            string[] temp11 = new string[encoded.Length];
            for (int i = 0; i < encoded.Length; i++)
            {
                for (int a = 0; a < encoded[i].Length; a++)
                    temp11[i] += "0";
            }
            for (int i = 0; i < x; i++)
            {
                int max = 0;
                for (int a = 0; a < total.Count; a++)
                {
                    if (total[a] > max)
                        max = total[a];
                }
                List<string> l1 = new List<string>();
                for (int b = 0; b < total.Count; b++)
                {
                    if (total[b] == max && total[b] != 0)
                    {
                        l1.Add(abc[b]);
                        total[b] = 0;
                    }
                }
                string t2 = "";
                t2 = frequencyOrder.Substring(0, l1.Count);
                string[] t4 = l1.ToArray();
                Array.Sort(t4);
                frequencyOrder = frequencyOrder.Remove(0, l1.Count);
                for (int c = 0; c < t4.Length; c++)
                {
                    for (int d = 0; d < encoded.Length; d++)
                    {
                        for (int e = 0; e < encoded[d].Length; e++)
                        {
                            if (temp11[d][e] == '0' && encoded[d][e].ToString() == t4[c])
                            {
                                temp11[d] = temp11[d].Insert(e, "1");
                                temp11[d] = temp11[d].Remove(e + 1, 1);
                                encoded[d] = encoded[d].Insert(e, t2[c].ToString());
                                encoded[d] = encoded[d].Remove(e + 1, 1);
                            }
                        }
                    }
                }
            }
            return encoded;
        }
    }
}
