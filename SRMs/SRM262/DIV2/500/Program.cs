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

    public class SortBooks
    {
        public int[] checkManually(string[] field1, string[] field2)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < field1.Length; i++)
            {
                int count1 = 0;
                int count2 = 0;
                bool ff1 = false;
                bool ff2 = false;
                foreach (string f in field1[i].ToLower().Split(' '))
                {
                    if (f != "")
                    {
                        count1++;
                        if (count1 > 3)
                        {
                            ff1 = true;
                            continue;
                        }
                    }
                    if (f == "the" || f == "and" || f == "of")
                    {
                        ff1 = true;
                        continue;
                    }
                }
                foreach (string f in field2[i].ToLower().Split(' '))
                {
                    if (f != "")
                    {
                        count2++;
                        if (count2 > 3)
                        {
                            ff2 = true;
                            continue;
                        }
                    }
                    if (f == "the" || f == "and" || f == "of")
                    {
                        ff2 = true;
                        continue;
                    }
                }
                if (count2 > 3)
                    ff2 = true;
                if (ff1 == true && ff2 == true || ff1 == false && ff2 == false)
                    res.Add(i);
            }
            return res.ToArray();
        }
    }
}
