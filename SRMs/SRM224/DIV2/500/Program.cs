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
            TwoTurtledoves x = new TwoTurtledoves();
            Console.WriteLine(x.presentType(12));
            Console.ReadLine();
        }
    }

    public class TwoTurtledoves
    {
        public int presentType(int n)
        {
            int a = 1;
            int result = 0;
            while (n > 0)
            {
                for (int i = a; i > 0; i--)
                {
                    for (int b = i; b > 0; b--)
                    {
                        n--;
                        result = i;
                        if (n == 0)
                            break;
                    }
                    if (n == 0)
                        break;
                }
                a++;
            }
            return result;
        }
    }
}
