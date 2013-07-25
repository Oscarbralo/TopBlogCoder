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
            Justifier x = new Justifier();
            string[] a = { "BOB", "TOMMY", "JIM" };
            Console.WriteLine(x.justify(a));
            Console.ReadLine();
        }
    }

    public class Justifier
    {
        public string[] justify(string[] textIn)
        {
            int max = 0;
            for (int i = 0; i < textIn.Length; i++)
            {
                if (textIn[i].Length > max)
                    max = textIn[i].Length;
            }
            for (int i = 0; i < textIn.Length; i++)
            {
                if (textIn[i].Length < max)
                {
                    while (textIn[i].Length < max)
                    {
                        textIn[i] = textIn[i].Insert(0, " ");
                    }
                }
            }
            return textIn;
        }
    }
}
