using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToTutorialChallenges
{
    class Solution
    {
        static void Main(String[] args)
        {
            string number = Console.ReadLine();
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(Console.ReadLine().Split(' ').ToList().IndexOf(number));
            Console.ReadLine();
        }
    }
}
