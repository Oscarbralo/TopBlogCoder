using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            AddMultiply x = new AddMultiply();
            Console.WriteLine(x.makeExpression(2));
            Console.ReadLine();
        }
    }

    public class AddMultiply
    {
        public int[] makeExpression(int y)
        {
            int temp1 = 0;
            int temp2 = 2;
            int temp3 = 0;
            if (y == 0)
            {
                temp1 = 2;
                temp2 = 2;
                temp3 = 4;
            }
            else if (y == 1)
            {
                temp1 = 2;
                temp2 = 2;
                temp3 = 3;
            }
            else
            {
                temp1 = y / 2;
                while ((temp1 * temp2) - y <= 1)
                {
                    temp1++;
                }
                temp3 = (temp1 * temp2) - y;
            }
            int[] result = { temp1, temp2, temp3 * -1 };
            return result;
        }
    }
}
