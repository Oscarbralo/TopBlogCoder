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
            CreatePairs x = new CreatePairs();
            int[] a = { 1, 0, 1, -1, 2, 3, -2, 2, -7 };
            Console.WriteLine(x.maximalSum(a));
            Console.ReadLine();
        }
    }

    public class CreatePairs
    {
        public int maximalSum(int[] data)
        {
            Array.Sort(data);
            int result = 0;
            int count = 0;
            int temp = data.Sum(x => x);
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            if (data.Length == 1)
                return data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0)
                    list1.Add(data[i]);
                else if (data[i] > 0)
                    list2.Add(data[i]);
                else
                    count++;
            }
            if (list1.Count > 1)
            {
                for (int i = 0; i < list1.Count - 1; i += 2)
                    result += (list1[i] * list1[i + 1]);
            }
            if (count > 0 && list1.Count % 2 == 1)
                list1.RemoveAt(list1.Count - 1);
            if (list2.Count > 1)
            {
                for (int i = list2.Count - 1; i > 0; i -= 2)
                {
                    if ((list2[i] + list2[i - 1]) > (list2[i] * list2[i - 1]))
                        result += (list2[i] + list2[i - 1]);
                    else
                        result += (list2[i] * list2[i - 1]);
                }
            }
            if (list1.Count == 1)
                result += list1[0];
            else if (list1.Count % 2 == 1)
                result += list1[list1.Count - 1];
            if (list2.Count == 1)
                result += list2[0];
            else if (list2.Count % 2 == 1)
                result += list2[0];
            return Math.Max(temp, result);
        }
    }
}
