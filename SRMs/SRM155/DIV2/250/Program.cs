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
            Quipu q = new Quipu();
            Console.WriteLine(q.readKnots("-XX--XXXX---XXX-"));
            Console.ReadLine();
        }
    }

    public class Quipu
    {
        public int readKnots(string knots)
        {
            string res = "";
            knots = knots.Remove(0, 1);
            knots = knots.Remove(knots.Length - 1, 1);
            string[] t = knots.Split('-');
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == "")
                    res += 0;
                else
                    res += t[i].ToString().Length;
            }
            return int.Parse(res);
        }
    }
}
