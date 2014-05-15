using System;
using System.Text;

namespace MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                int x = 0;
                for (int a = 1; a <= 12; a++)
                {
                    StringBuilder sb = new StringBuilder((i * a).ToString());
                    while(sb.Length < 4)
                        sb = sb.Insert(0, " ");
                    list[x] = sb.ToString();
                    x++;
                }
                Console.WriteLine(string.Join("", list));
            }
            Console.ReadLine();
        }
    }
}
