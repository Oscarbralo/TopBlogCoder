using System;

namespace A.Sleuth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower().Replace(" ","").Replace(",","").Replace(".","").Replace("?","").Replace("!","");
            string correct = "aeiouy";
            if(correct.Contains(input[input.Length - 1].ToString()))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
