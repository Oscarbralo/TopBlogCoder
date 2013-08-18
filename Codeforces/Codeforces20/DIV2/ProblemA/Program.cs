using System;
using System.Text;

namespace A.BerOS_file_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            bool repeated = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '/')
                {
                    if (repeated == false)
                    {
                        result.Append(input[i]);
                        repeated = true;
                    }
                }
                else
                {
                    result.Append(input[i]);
                    repeated = false;
                }
            }
            if (result[result.Length - 1] == '/' && result.Length > 1)
                result.Remove(result.Length - 1, 1);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
