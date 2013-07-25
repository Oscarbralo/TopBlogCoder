using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TopFox
    {
        public int possibleHandles(string familyName, string givenName)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= familyName.Length; i++)
            {
                for (int a = 1; a <= givenName.Length; a++)
                {
                    string t1 = familyName.Substring(0, i);
                    string t2 = givenName.Substring(0, a);
                    if (!list.Contains(t1 + t2))
                        list.Add(t1 + t2);
                }
            }
            return list.Count;
        }
    }
}
