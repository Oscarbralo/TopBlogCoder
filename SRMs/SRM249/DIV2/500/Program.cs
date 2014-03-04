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
            FieldPairParse x = new FieldPairParse();
            string[] a = {
"XXXX      X  X           X X   X",
"XX       XXX XX   X   X   X XXX "
};
            Console.WriteLine(x.getPairs(a));
            Console.ReadLine();
        }
    }

    public class FieldPairParse
    {
        public int[] getPairs(string[] data)
        {
            int a = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < data[0].Length; i++)
            {
                Regex r = new Regex(@"\s+");
                int count = data.Count(x => x[i] == ' ');
                if (count == data.Length)
                {
                    if (a == 0)
                    {
                        result.Add(1);
                        a++;
                    }
                    else
                        result[result.Count - 1]++;
                }
                else
                    a = 0;
            }
            return result.ToArray<int>();
        }
    }
}
