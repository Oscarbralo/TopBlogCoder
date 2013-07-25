using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            CCipher c = new CCipher();
            Console.WriteLine(c.decode("VQREQFGT",2));
            Console.ReadLine();
        }
    }

    public class CCipher
    {
        public string decode(string cipherText, int shift)
        {
            string abc = "ZYXWVUTSRQPONMLKJIHGFEDCBAZYXWVUTSRQPONMLKJIHGFEDCBA";
            string res = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                int temp = abc.IndexOf(cipherText[i].ToString());
                res += abc[temp + shift];
            }
            return res;
        }
    }
}
