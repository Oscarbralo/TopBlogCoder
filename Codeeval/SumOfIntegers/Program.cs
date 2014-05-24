using System;
using System.IO;
using System.Linq;

namespace SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader reader = File.OpenText(args[0]))
            //    while (!reader.EndOfStream)
            //    {
                    int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray<int>();
                    int bigSum = int.MaxValue * -1;
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        for (int a = numbers.Length; a > i; a--)
                        {
                            bigSum = Math.Max(numbers.Skip(i).Take(a - i).Sum(), bigSum);
                        }
                    }
                    Console.WriteLine(bigSum == int.MaxValue * -1 ? numbers[0] : bigSum);
                //}
            Console.ReadLine();
        }
    }
}
