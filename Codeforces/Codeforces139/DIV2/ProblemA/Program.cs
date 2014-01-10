using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PetrAndBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int[] pages = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int currentPage = -1;
            while (totalPages > 0)
            {
                currentPage = (currentPage + 1) % 7;
                totalPages -= pages[currentPage];
            }
            Console.WriteLine(++currentPage);
            Console.ReadLine();
        }
    }
}
