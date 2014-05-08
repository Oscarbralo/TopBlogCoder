using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PoliceRecruits
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int result = 0;
            int people = 0;
            int crimes = 0;
            int[] calls = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            for (int i = 0; i < calls.Length; i++)
            {
                if (calls[i] > 0)
                {
                    if (crimes > 0)
                    {
                        crimes = 0;
                        people += Math.Abs(calls[i]);
                    }
                    else
                        people += Math.Abs(calls[i]);
                }
                else
                {
                    if (people == 0)
                    {
                        result += Math.Abs(calls[i]);
                        crimes++;
                    }
                    else
                        people -= Math.Abs(calls[i]);
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
