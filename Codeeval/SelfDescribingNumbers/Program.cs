using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace SelfDescribingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "2020";
            bool finish = true;
            for (int i = 0; i < line.Length; i++)
            {
                if (int.Parse(line[i].ToString()) != line.Count(x => x.ToString() == i.ToString()))
                {
                    finish = false;
                    break;
                }
            }
            Console.WriteLine(finish == true ? 1 : 0);
            Console.ReadLine();
        }
    }
}
