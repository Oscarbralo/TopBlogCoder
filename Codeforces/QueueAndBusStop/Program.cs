using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueAndBusStop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select((x) => int.Parse(x)).ToArray<int>();
            List<int> list = new List<int>();
            Console.ReadLine().Split(' ').Select((x) => int.Parse(x)).ToList().ForEach((x) => list.Add(x));
            int totalBuses = 0;
            int temp = 0;
            int peopleInBus = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (peopleInBus + list[i] <= cases[1])
                {
                    peopleInBus += list[i];
                    temp++;
                }
                else if (peopleInBus + list[i] > cases[1] || peopleInBus == cases[1])
                {
                    totalBuses++;
                    temp = 0;
                    peopleInBus = 0;
                    i--;
                }
            }
            totalBuses += peopleInBus > 0 ? 1 : 0;
            Console.WriteLine(totalBuses);
            Console.ReadLine();
        }
    }
}
