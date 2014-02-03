using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _400
{
    class Program
    {
        static void Main(string[] args)
        {
            grafixCorrupt x = new grafixCorrupt();
            string[] a = { "cat", "cab", "lab" };
            Console.WriteLine(x.selectWord(a, "dab"));
            Console.ReadLine();
        }
    }

    public class grafixCorrupt
    {
        public int selectWord(string[] dictionary, string candidate)
        {
            int result = 0;
            int resultMax = 0;
            for (int i = 0; i < dictionary.Length; i++)
            {
                int j = -1;
                int temp = dictionary[i].Where(x => dictionary[i][++j].ToString() == candidate[j].ToString()).Count();
                if (temp > resultMax)
                {
                    resultMax = temp;
                    result = i;
                }
            }
            return result;
        }
    }
}
