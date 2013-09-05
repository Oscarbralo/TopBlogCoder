using System;

namespace A.Autocomplete
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int cases = int.Parse(Console.ReadLine());
            string[] input = new string[cases];
            for (int i = 0; i < cases; i++)
                input[i] = Console.ReadLine();
            Array.Sort(input);
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(word))
                {
                    result = input[i];
                    break;
                }
            }
            if (result == "")
                result = word;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
