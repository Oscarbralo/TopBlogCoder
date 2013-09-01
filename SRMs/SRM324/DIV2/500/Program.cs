using System;
using System.Linq;
using System.Text;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeDecoding x = new PalindromeDecoding();
            int[] a = { 2, 3, 1, 7 };
            int[] b = { 1, 1, 2, 2 };
            Console.WriteLine(x.decode("Misip", a, b));
            Console.ReadLine();
        }
    }

    public class PalindromeDecoding
    {
        public string decode(string code, int[] position, int[] length)
        {
            StringBuilder Ccode = new StringBuilder(code);
            if (position.Length == 0)
                return code;
            for (int i = 0; i < position.Length; i++)
            {
                string temp = Ccode.ToString().Substring(position[i], length[i]);
                StringBuilder sb = new StringBuilder();
                for (int a = temp.Length - 1; a >= 0;a--)
                    sb.Append(temp[a]);
                Ccode = Ccode.Insert(position[i]+length[i], sb.ToString());
            }
            return Ccode.ToString();
        }
    }
}
