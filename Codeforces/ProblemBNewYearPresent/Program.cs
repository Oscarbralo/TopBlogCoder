using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] coins = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            StringBuilder sb = new StringBuilder();
            int i = 0;
            bool right = true;
            bool result = false;
            while(coins.Where(x => x == 0).Count() != n)
            {
                if (right)
                {
                    if (coins[i] > 0)
                    {
                        sb.Append("P");
                        coins[i]--;
                    }
                    i++;
                }
                else
                {
                    if (coins[i] > 0)
                    {
                        sb.Append("P");
                        coins[i]--;
                    }
                    i--;
                }
                if (coins.Where(x => x == 0).Count() == n)
                    result = true;
                if (i == n)
                {
                    right = !right;
                    i -= 2;
                }
                else if (i == -1)
                {
                    right = !right;
                    i += 2;
                }
                if (!result)
                {
                    if (right)
                        sb.Append("R");
                    else
                        sb.Append("L");
                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
