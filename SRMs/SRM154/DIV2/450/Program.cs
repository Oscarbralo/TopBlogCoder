using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _450
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperRot x = new SuperRot();
            Console.WriteLine(x.decoder("5678901234"));
            Console.ReadLine();
        }
    }

    public class SuperRot
    {
        public string decoder(string message)
        {
            string res = "";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string num = "0123456789";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    res += " ";
                    continue;
                }
                if (ABC.Contains(message[i].ToString()))
                {
                    if (ABC.IndexOf(message[i]) < ABC.Length / 2)
                        res += ABC[ABC.IndexOf(message[i]) + 13];
                    else
                        res += ABC[ABC.IndexOf(message[i]) - 13];
                }
                else if (abc.Contains(message[i].ToString()))
                {
                    if (abc.IndexOf(message[i]) < abc.Length / 2)
                        res += abc[abc.IndexOf(message[i]) + 13];
                    else
                        res += abc[abc.IndexOf(message[i]) - 13];
                }
                else
                {
                    if (num.IndexOf(message[i]) < num.Length / 2)
                        res += num[num.IndexOf(message[i]) + 5];
                    else
                        res += num[num.IndexOf(message[i]) - 5];
                }
            }
            return res;
        }
    }
}
