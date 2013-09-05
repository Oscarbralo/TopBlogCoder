using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace A.Bar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alcohol = { "ABSINTH", "BEER", "BRANDY", "CHAMPAGNE", "GIN", "RUM", "SAKE", "TEQUILA", "VODKA", "WHISKEY", "WINE" };
            int cases = int.Parse(Console.ReadLine());
            int result = 0;
            Regex r = new Regex(@"\d");
            for (int i = 0; i < cases; i++)
            {
                string temp = Console.ReadLine();
                if (r.IsMatch(temp))
                {
                    if (int.Parse(temp) < 18)
                        result++;
                }
                else
                {
                    if (alcohol.Contains(temp))
                        result++;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
