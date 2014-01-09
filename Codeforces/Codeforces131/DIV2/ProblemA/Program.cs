using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace cAPSLOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = Console.ReadLine();
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int temp = res.Substring(1, res.Length - 1).Select(x => x).Where(x => abc.Contains(x.ToString())).Count();
            if (res.Length - temp == 1)
            {
                if (abc.Contains(res[0].ToString()))
                    Console.WriteLine(res.ToLower());
                else
                    Console.WriteLine(res.ToLower().Insert(0, res[0].ToString().ToUpper()).Remove(1, 1));
            }
            else
                Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
