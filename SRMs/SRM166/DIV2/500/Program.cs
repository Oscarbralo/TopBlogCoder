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
            BinaryCardinality x = new BinaryCardinality();
            int[] a = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(x.arrange(a));
            Console.ReadLine();
        }
    }

    public class BinaryCardinality
    {
        public int[] arrange(int[] numbers)
        {
            string[] list = new string[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                string n = Convert.ToString(numbers[i], 2);
                int count = n.Select(x => x).Where(x => x == '1').Count();
                if(list[count] == null)
                    list[count] += numbers[i];
                else
                    list[count] += " " + numbers[i];
            }
            List<int> result = new List<int>();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                {
                    string[] t = list[i].Split(' ');
                    int[] temp = t.Select(x => int.Parse(x.ToString())).ToArray();
                    Array.Sort(temp);
                    for (int a = 0; a < temp.Length; a++)
                        result.Add(temp[a]);
                }
            }
            return result.ToArray();
        }
    }
}
