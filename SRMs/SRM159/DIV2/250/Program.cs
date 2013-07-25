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
            X x = new X();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class StreetParking
    {
        public int freeParks(string street)
        {
            int res = 0;
            street = "*" + street + "**";
            for (int i = 1; i < street.Length - 2; i++)
            {
                string current = street[i].ToString();
                string prev = street[i - 1].ToString();
                string next = street[i + 1].ToString();
                string next2 = street[i + 2].ToString();
                if (current == "-" && prev != "S" && next != "S" && next != "B" && next2 != "B")
                    res++;
            }
            return res;
        }
    }
}
