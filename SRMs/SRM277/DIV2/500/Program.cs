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
            RogersPhenomenon x = new RogersPhenomenon();
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            Console.WriteLine(x.countTriggers(a, b));
            Console.ReadLine();
        }
    }

    public class RogersPhenomenon
    {
        public int countTriggers(int[] set1, int[] set2)
        {
            double[] s1 = set1.Select(x => double.Parse(x.ToString())).ToArray<double>();
            double[] s2 = set2.Select(x => double.Parse(x.ToString())).ToArray<double>();
            double final1 = s1.Sum() / s1.Length;
            double final2 = s2.Sum() / s2.Length;
            int result = 0;
            if (s1.Length > 1)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    List<double> list1 = s1.ToList();
                    List<double> list2 = s2.ToList();
                    list2.Add(list1[i]);
                    list1.RemoveAt(i);
                    double temp1 = list1.Sum() / list1.Count;
                    double temp2 = list2.Sum() / list2.Count;
                    if (temp1 > final1 && temp2 > final2)
                        result++;
                }
            }
            if (s1.Length > 1)
            {
                for (int i = 0; i < s2.Length; i++)
                {
                    List<double> list1 = s1.ToList();
                    List<double> list2 = s2.ToList();
                    list1.Add(list2[i]);
                    list2.RemoveAt(i);
                    double temp1 = list1.Sum() / list1.Count;
                    double temp2 = list2.Sum() / list2.Count;
                    if (temp1 > final1 && temp2 > final2)
                        result++;
                }
            }
            return result;
        }
    }
}
