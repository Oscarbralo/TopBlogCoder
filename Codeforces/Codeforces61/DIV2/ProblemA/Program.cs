using System;
using System.Text;

namespace A.Ultra_Fast_Mathematician
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                    sb.Append("0");
                else
                    sb.Append("1");
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
