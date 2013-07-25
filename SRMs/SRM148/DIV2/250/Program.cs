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
            DivisorDigits d = new DivisorDigits();
            Console.WriteLine(d.howMany(100000));
            Console.ReadLine();
        }
    }

    public class DivisorDigits
    {
        public int howMany(int number)
        {
            int res = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (int.Parse(number.ToString()[i].ToString()) != 0)
                    if (number % int.Parse(number.ToString()[i].ToString()) == 0 && int.Parse(number.ToString()[i].ToString()) != 0)
                        res++;
            }
            return res;
        }
    }
}
