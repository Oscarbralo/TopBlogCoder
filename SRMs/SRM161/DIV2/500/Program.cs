using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace SRM161
{
    class Program
    {
        static void Main(string[] args)
        {
            StringTrain x = new StringTrain();
            string[] cars = { "AAAAA", "AAAAA", "AAAAA" };
            Console.WriteLine(x.buildTrain(cars));
            Console.ReadLine();
        }
    }

    public class StringTrain
    {
        public string buildTrain(string[] cars)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(cars[0]);
            for (int i = 1; i < cars.Length; i++)
            {
                if (cars[i].Length == 1) { continue; }
                for (int a = cars[i].Length - 1; a > 0; a--)
                {
                    if (sb.ToString().EndsWith(cars[i].Substring(0, a)) && sb.ToString() != cars[i].Substring(0, a))
                    {
                        sb.Append(cars[i].Substring(a, cars[i].Length - a));
                        break;
                    }
                }
            }
            int len = sb.Length;
            StringBuilder result = new StringBuilder();
            for (int b = sb.Length - 1; b >= 0; b--)
                if (!result.ToString().Contains(sb[b].ToString()))
                    result = result.Insert(0, sb[b].ToString());
            return len.ToString() + " " + result;
        }
    }
}
