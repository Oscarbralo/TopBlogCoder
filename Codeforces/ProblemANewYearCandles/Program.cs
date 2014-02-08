using System;
using System.Linq;

namespace NewYearCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candles = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int res = candles[0];
            while (candles[0] >= candles[1])
            {
                res += candles[0] / candles[1];
                candles[0] = (candles[0] % candles[1]) + (candles[0] / candles[1]);
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
