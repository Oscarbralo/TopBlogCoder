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
            Substitute x = new Substitute();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class Substitute
    {
        public int getValue(string key, string code)
        {
            string res = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (key.Contains(code[i].ToString()))
                    if (key.IndexOf(code[i].ToString()) == key.Length - 1)
                        res += "0";
                    else
                        res += (key.IndexOf(code[i].ToString()) + 1).ToString();
            }
            return int.Parse(res);
        }
    }
}
