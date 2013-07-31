using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Regex r = new Regex("^[a-z]{0,3}[0-9]{2,8}[A-Z]{3,}");
        int cases = int.Parse(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            Console.WriteLine(r.IsMatch(Console.ReadLine()) ? "VALID" : "INVALID");
        }
        Console.ReadLine();
    }
}
