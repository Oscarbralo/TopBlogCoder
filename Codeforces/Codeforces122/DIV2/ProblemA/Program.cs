using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace AlmostLucky
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lucky l = new Lucky();
            int n = int.Parse(Console.ReadLine());
            if (l.isLucky(n))
                Console.WriteLine("YES");
            else
            {
                bool finish = false;
                for (int i = 1; i <= n; i++)
                {
                    if (l.isLucky(i) && n % i == 0)
                    {
                        finish = true;
                        break;
                    }
                }
                Console.WriteLine((finish) ? "YES" : "NO");
            }
            Console.ReadLine();
        }
    }

    public class Lucky
    {
        public bool isLucky(int n)
        {
            int sum = n.ToString().Select(x => x).Where(x => x == '4').Count();
            sum += n.ToString().Select(x => x).Where(x => x == '7').Count();
            if (sum == n.ToString().Length)
                return true;
            else
                return false;
        }
    }
}
