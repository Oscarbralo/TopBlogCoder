using System;

namespace A._123_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            int[] res = new int[3];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == "1")
                    res[0]++;
                else if (temp[i] == "2")
                    res[1]++;
                else
                    res[2]++;
            }
            int max = Math.Max(res[0], Math.Max(res[1], res[2]));
            if (res[0] == max)
                Console.WriteLine(res[1] + res[2]);
            else if (res[1] == max)
                Console.WriteLine( res[0] + res[2]);
            else
                Console.WriteLine(res[0] + res[1]);
            Console.ReadLine();
        }
    }
}
