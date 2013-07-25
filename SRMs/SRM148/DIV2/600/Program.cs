using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _600
{
    class Program
    {
        static void Main(string[] args)
        {
            CeyKaps c = new CeyKaps();
            string[] a = { "A:B", "B:C", "C:D", "D:E", "E:A" };
            Console.WriteLine(c.decipher("ABCDE",a));
            Console.ReadLine();
        }
    }

    public class CeyKaps
    {
        public string decipher(string typed, string[] switches)
        {
            for (int i = 0; i < switches.Length; i++)
            {
                for (int a = 0; a < typed.Length; a++)
                {
                    if (switches[i][0] == typed[a])
                    {
                        typed = typed.Insert(a, switches[i][2].ToString());
                        typed = typed.Remove(a + 1, 1);
                    }
                    else if (switches[i][2] == typed[a])
                    {
                        typed = typed.Insert(a, switches[i][0].ToString());
                        typed = typed.Remove(a + 1, 1);
                    }
                }
            }
            return typed;
        }
    }
}
