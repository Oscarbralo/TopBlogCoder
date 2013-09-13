using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A.Room_Leader
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string result = "";
            int max = -9999999;
            for (int i = 0; i < cases; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                int[] contests = { int.Parse(temp[3]), int.Parse(temp[4]), int.Parse(temp[5]), int.Parse(temp[6]), int.Parse(temp[7]) };
                int totalPoints = contests.Sum(x => x);
                totalPoints += (int.Parse(temp[1]) * 100);
                totalPoints -= (int.Parse(temp[2]) * 50);
                if (totalPoints > max)
                {
                    max = totalPoints;
                    result = temp[0];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
