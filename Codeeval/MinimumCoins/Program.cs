using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                int n = int.Parse(reader.ReadLine());
                int temp = 0;
                int minCoins = 0;
                while (temp < n)
                {
                    temp += 5;
                    minCoins++;
                }
                if (temp == n)
                    Console.WriteLine(minCoins);
                else
                {
                    temp -= 5;
                    minCoins--;
                    while (temp < n)
                    {
                        temp += 3;
                        minCoins++;
                    }
                    if (temp == n)
                        Console.WriteLine(minCoins);
                    else
                    {
                        temp -= 3;
                        minCoins--;
                        while (temp < n)
                        {
                            temp += 1;
                            minCoins++;
                        }
                        if (temp == n)
                            Console.WriteLine(minCoins);
                    }
                }
            }
    }
}