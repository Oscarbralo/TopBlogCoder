using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatAmt s = new FormatAmt();
            Console.WriteLine(s.amount(123456, 9));
            Console.ReadLine();
        }
    }

    public class FormatAmt
    {
        public string amount(int dollars, int cents)
        {
            string c = "";
            if (cents.ToString().Length == 1)
                c = ".0" + cents;
            else if (cents == 0)
                c = ".00";
            else
                c = "." + cents;
            string d = "";
            int x = 0;
            for (int i = dollars.ToString().Length - 1 + 1; i >= 1; i--)
            {
                if (i % 3 == 0 && i != dollars.ToString().Length - 1 + 1)
                {
                    d += "," + dollars.ToString()[x];
                    x++;
                }
                else
                {
                    d += dollars.ToString()[x];
                    x++;
                }
            }
            return "$" + d + c;
        }
    }
}
