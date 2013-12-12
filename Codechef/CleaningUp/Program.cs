using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleaningUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                List<int> chef = new List<int>();
                List<int> assistant = new List<int>();
                bool chefTurn = true;
                int init = 1;
                string[] jobs = Console.ReadLine().Split(' ');
                int[] jobsCompleted = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToArray<int>();
                while (init <= int.Parse(jobs[0]))
                {
                    if (!jobsCompleted.Contains(init))
                    {
                        if (chefTurn)
                            chef.Add(init);
                        else
                            assistant.Add(init);
                        chefTurn = !chefTurn;
                    }
                    init++;
                }
                Console.WriteLine(string.Join(" ", chef));
                Console.WriteLine(string.Join(" ", assistant));
            }
            Console.ReadLine();
        }
    }
}
