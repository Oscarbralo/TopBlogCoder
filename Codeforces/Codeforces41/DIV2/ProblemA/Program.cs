using System;

namespace A.Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine().ToLower();
            string input2 = Console.ReadLine().ToLower();
            bool correct = true;
            if (input1.Length != input2.Length)
                Console.WriteLine("NO");
            else
            {
                int last = input2.Length - 1;
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] == 's')
                    {
                        if (input2[last] == 't')
                        {
                            last--;
                            continue;
                        }
                    }
                    else
                    {
                        if (input1[i] != input2[last])
                        {
                            correct = false;
                            Console.WriteLine("NO");
                            break;
                        }
                    }
                    last--;
                }
            }
            if(correct)
                Console.WriteLine("YES");
            Console.ReadLine();
        }
    }
}
