using System;
using System.Text.RegularExpressions;

namespace A.Chat_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex r = new Regex(@"[a-z]{0,}[h]{1}[a-z]{0,}[e]{1}[a-z]{0,}[l]{1}[a-z]{0,}[l]{1}[a-z]{0,}[o]{1}[a-z]{0,}");
            bool result = r.IsMatch(s);
            if(result)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
