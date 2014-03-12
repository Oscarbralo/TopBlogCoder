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
                string line = reader.ReadLine();
                int cases = int.Parse(line);
                bool result = false;
                for (int i = 0; i < 100; i++)
                {
                    cases = (int)cases.ToString().Select(x => Math.Pow(double.Parse(x.ToString()), 2)).Sum();
                    if (cases == 1)
                    {
                        result = true;
                        break;
                    }
                }
                Console.WriteLine(result ? 1 : 0);
            }
    }
}
