using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string number1 = Console.ReadLine();
            int lenNumber1 = number1.Length / 2;
            string midLeftTop = number1.Substring((number1.Length + 1) / 2, lenNumber1);
            string midRightTop = number1.Substring(0, lenNumber1);
            bool finish = false;
            if (number1.Select(x => x).Where(x => x == '4').Count() + number1.Select(x => x).Where(x => x == '7').Count() == number1.Length)
                finish = true;
            Console.WriteLine(midLeftTop.Sum(x => int.Parse(x.ToString())) == midRightTop.Sum(x => int.Parse(x.ToString())) && finish == true ? "YES" : "NO");
            Console.ReadLine();
        }
    }
}
