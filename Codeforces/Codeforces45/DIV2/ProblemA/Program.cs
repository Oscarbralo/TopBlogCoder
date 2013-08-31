using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace A.Codecraft_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string actualMonth = Console.ReadLine();
            int numberMonths = int.Parse(Console.ReadLine());
            List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int actual = (months.IndexOf(actualMonth) + numberMonths) % 12;
            Console.WriteLine(months[actual]);
            Console.ReadLine();
        }
    }
}
