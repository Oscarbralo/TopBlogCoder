using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[3];
            int[] dices = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            for (int i = 1; i <= 6; i++)
            {
                if (Math.Abs(i - dices[0]) < Math.Abs(i - dices[1]))
                    result[0]++;
                else if(Math.Abs(i - dices[0]) == Math.Abs(i - dices[1]))
                    result[1]++;
                else
                    result[2]++;
            }
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}
