using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int numbers = int.Parse(Console.ReadLine());
            List<int> n = Console.ReadLine().Split(' ').OrderByDescending(x => int.Parse(x)).Select(x => int.Parse(x)).ToList<int>();
            if (n.Contains(1))
            {
                Console.WriteLine(n.Count);
            }
            else
            {
                int count = n.Count;
                for (int i = n.Max(); i > 0; i--)
                {
                    if (n.Where(x => x % i == 0).Count() == count)
                    {
                        Console.WriteLine(i * count);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}