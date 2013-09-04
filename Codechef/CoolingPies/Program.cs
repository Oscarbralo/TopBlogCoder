using System;

namespace Cooling_Pies
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int numberPies = int.Parse(Console.ReadLine());
                string[] pies = Console.ReadLine().Split(' ');
                string[] racks = Console.ReadLine().Split(' ');
                int[] p = new int[numberPies];
                int[] r = new int[numberPies];
                for (int a = 0; a < pies.Length; a++)
                {
                    p[a] = int.Parse(pies[a]);
                    r[a] = int.Parse(racks[a]);
                }
                Array.Sort(p);
                Array.Sort(r);
                int count = r.Length - 1;
                int actual = p.Length - 1;
                int result = 0;
                while (actual >= 0)
                {
                    if (p[actual] <= r[count])
                    {
                        result++;
                        count--;
                        actual--;
                    }
                    else
                        actual--;
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
