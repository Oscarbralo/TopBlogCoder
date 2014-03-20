using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace FirstNonRdCharacterepeate
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "tooth";
            for (int i = 0; i < line.Length; i++)
            {
                if (line.Where(x => x == line[i]).Count() == 1)
                {
                    Console.WriteLine(line[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
