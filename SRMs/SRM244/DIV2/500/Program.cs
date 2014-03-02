using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _400
{
    class Program
    {
        static void Main(string[] args)
        {
            PhonePad x = new PhonePad();
            Console.WriteLine(x.fingerMovement("8606335540"));
            Console.ReadLine();
        }
    }

    public class PhonePad
    {
        public int fingerMovement(string phoneNumber)
        {
            int result = 0;
            int[] init = { 1, 1 };
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                switch (phoneNumber[i])
                {
                    case '1':
                        result += Math.Abs(init[0] - 0) + Math.Abs(init[1] - 0);
                        init[0] = 0;
                        init[1] = 0;
                        break;
                    case '2':
                        result += Math.Abs(init[0] - 0) + Math.Abs(init[1] - 1);
                        init[0] = 0;
                        init[1] = 1;
                        break;
                    case '3':
                        result += Math.Abs(init[0] - 0) + Math.Abs(init[1] - 2);
                        init[0] = 0;
                        init[1] = 2;
                        break;
                    case '4':
                        result += Math.Abs(init[0] - 1) + Math.Abs(init[1] - 0);
                        init[0] = 1;
                        init[1] = 0;
                        break;
                    case '5':
                        result += Math.Abs(init[0] - 1) + Math.Abs(init[1] - 1);
                        init[0] = 1;
                        init[1] = 1;
                        break;
                    case '6':
                        result += Math.Abs(init[0] - 1) + Math.Abs(init[1] - 2);
                        init[0] = 1;
                        init[1] = 2;
                        break;
                    case '7':
                        result += Math.Abs(init[0] - 2) + Math.Abs(init[1] - 0);
                        init[0] = 2;
                        init[1] = 0;
                        break;
                    case '8':
                        result += Math.Abs(init[0] - 2) + Math.Abs(init[1] - 1);
                        init[0] = 2;
                        init[1] = 1;
                        break;
                    case '9':
                        result += Math.Abs(init[0] - 2) + Math.Abs(init[1] - 2);
                        init[0] = 2;
                        init[1] = 2;
                        break;
                    case '0':
                        result += Math.Abs(init[0] - 3) + Math.Abs(init[1] - 1);
                        init[0] = 3;
                        init[1] = 1;
                        break;
                    case '*':
                        result += Math.Abs(init[0] - 3) + Math.Abs(init[1] - 0);
                        init[0] = 3;
                        init[1] = 0;
                        break;
                    case '#':
                        result += Math.Abs(init[0] - 3) + Math.Abs(init[1] - 2);
                        init[0] = 3;
                        init[1] = 2;
                        break;
                }
            }
            return result;
        }
    }
}
