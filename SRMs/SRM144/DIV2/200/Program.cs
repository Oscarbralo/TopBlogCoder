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

    public class Time
    {
        public string whatTime(int seconds)
        {
            int H = seconds / 3600;
            int M = (seconds % 3600) / 60;
            int S = (seconds % 3600) % 60;
            return H + ":" + M + ":" + S;
        }
    }
}
