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
            List<string> array = Console.ReadLine().Split(' ').ToList();
            int result = array.IndexOf(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
