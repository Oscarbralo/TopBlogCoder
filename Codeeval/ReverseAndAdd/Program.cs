using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ReverseAndAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            while (!p.IsPalindrome(n.ToString()) || n.ToString().Length <= 1)
            {
                n += int.Parse(string.Join("", n.ToString().Reverse().Select(x => x.ToString()).ToArray<string>()));
                number++;
            }
            Console.WriteLine(string.Format("{0} {1}", number, n));
            //    }
            Console.ReadLine();
        }

        public bool IsPalindrome(string number)
        {
            int j = number.Length - 1;
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[j])
                    return false;
                j--;
            }
            return true;
        }
    }
}
