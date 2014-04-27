using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Squats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] text = Console.ReadLine().Select(x => x.ToString()).ToArray();
            int xs = text.Count(x => x == "x");
            int Xs = text.Count(x => x == "X");
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "x" && xs > text.Length / 2)
                {
                    text[i] = "X";
                    xs--; 
                    result++;
                }
                else if(text[i] == "X" && Xs > text.Length / 2)
                {
                    text[i] = "x";
                    Xs--;
                    result++;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(string.Join("", text));
            Console.ReadLine();
        }
    }
}
