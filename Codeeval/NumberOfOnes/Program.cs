using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                int n = int.Parse(reader.ReadLine());
                Console.WriteLine(Convert.ToString(n, 2).Count(x => x == '1'));
            }
    }
}