using System;

namespace A.IQ_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            bool finish = false;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int a = 0; a < numbers.Length; a++)
                {
                    if (a != i)
                    {
                        if (Math.Abs(int.Parse(numbers[i]) - int.Parse(numbers[a])) % 2 == 1)
                            count++;
                    }
                    if (count > 1)
                    {
                        finish = true;
                        result = i + 1;
                    }
                }
                if (finish)
                    break;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
