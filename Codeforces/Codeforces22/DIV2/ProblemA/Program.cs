using System;
using System.Collections.Generic;

namespace A.Second_Order_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                if (!list.Contains(int.Parse(temp[i])))
                    list.Add(int.Parse(temp[i]));
            }
            int[] numbers = list.ToArray();
            Array.Sort(numbers);
            if (numbers.Length > 1)
                Console.WriteLine(numbers[1]);
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
