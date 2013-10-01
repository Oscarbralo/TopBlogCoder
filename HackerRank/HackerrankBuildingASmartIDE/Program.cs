using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuildingASmartID
{
    class Solution
    {
        static void Main(String[] args)
        {
            bool x = true;
            for (int a = 0; a < 15; a++)
            {
                string temp = Console.ReadLine();
                if (temp.Contains("java"))
                {
                    Console.WriteLine("Java");
                    x = false;
                    break;
                }
                else if (temp.Contains("stdio"))
                {
                    Console.WriteLine("C");
                    x = false;
                    break;
                }
            }
            if (x)
                Console.WriteLine("Python");
        }
    }
}
