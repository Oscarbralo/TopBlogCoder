using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ProblemAPasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            if (text.Any(x => abc.Contains(x)) && text.Any(x => ABC.Contains(x)) && text.Any(x => numbers.Contains(x)) && text.Length >= 5)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Too weak");
            Console.ReadLine();
        }
    }
}
