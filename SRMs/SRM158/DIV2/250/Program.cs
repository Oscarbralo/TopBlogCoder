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
            TireRotation x = new TireRotation();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class TireRotation
    {
        public int getCycle(string initial, string current)
        {
            int x = 1;
            if (initial == current)
                return 1;
            while (x <= 4)
            {
                string temp = initial[3].ToString() + initial[2].ToString() + initial[0].ToString() + initial[1].ToString();
                x++;
                if (temp == current)
                    return x;
                else
                    initial = temp;
            }
            return -1;
        }
    }
}
