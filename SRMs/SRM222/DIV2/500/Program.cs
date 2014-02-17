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
            GroceryBagger x = new GroceryBagger();
            string[] a = {"DAIRY",
 "DAIRY",
 "PRODUCE",
 "PRODUCE",
 "PRODUCE",
 "MEAT"};
            Console.WriteLine(x.minimumBags(2, a));
            Console.ReadLine();
        }
    }

    public class GroceryBagger
    {
        public int minimumBags(int strength, string[] itemType)
        {
            List<string> items = new List<string>();
            List<int> total = new List<int>();
            foreach (string item in itemType)
            {
                if (!items.Contains(item))
                {
                    items.Add(item);
                    total.Add(1);
                }
                else
                    total[items.IndexOf(item)]++;
            }
            int result = 0;
            for (int i = 0; i < items.Count; i++)
            {
                result += total[i] / strength;
                if (total[i] % strength > 0)
                    result++;
            }
            return result;
        }
    }
}
