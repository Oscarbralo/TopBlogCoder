using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int cases = int.Parse(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            int[] temp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int total = temp[0] / temp[1];
            int wrappers = total;
            while (wrappers >= temp[2])
            {
                int temp2 = wrappers / temp[2];
                total += temp2;
                wrappers = (wrappers - (temp2 * temp[2])) + temp2;
            }
            Console.WriteLine(total);
        }
        Console.ReadLine();
    }
}