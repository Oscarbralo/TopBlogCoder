using System;
using System.Text;

namespace A.Ball_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int actual = 0;
            int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cases - 1; i++)
            {
                actual += count;
                if (actual >= cases)
                    actual %= cases;
                sb.Append((actual + 1).ToString() + " ");
                count++;
            }
            sb = sb.Remove(sb.Length - 1,1);
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
