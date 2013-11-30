using System;
using System.Linq;

namespace ValeraAndPlates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int days = int.Parse(s[0]);
            int bowls = int.Parse(s[1]);
            int plates = int.Parse(s[2]);
            string[] temp = Console.ReadLine().Split(' ');
            int ones = temp.Select(x => x).Where(x => x == "1").Count();
            int twos = temp.Select(x => x).Where(x => x == "2").Count();
            bowls -= ones;
            int result = (bowls < 0) ? bowls * -1 : 0;
            while (bowls > 0)
            {
                twos--;
                bowls--;
            }
            plates -= twos;
            if (plates < 0)
                result += (plates * -1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
