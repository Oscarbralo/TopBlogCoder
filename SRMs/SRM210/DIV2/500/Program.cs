using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            DrivingDirections x = new DrivingDirections();
            string[] a = { "Start on  ", "Turn LEFT on  0123456789 - ", "Turn RIGHT on  0123456789 - ", "Turn LEFT on                                      ", "Turn RIGHT on                                     ", "Turn LEFT on -a0b1c2d3e4f5g6h7i8j9k ", "Turn RIGHT on -A0B1C2D3E4F5G6H7I8J9K ", "Turn LEFT on -", "Turn RIGHT on -" };
            Console.WriteLine(x.reverse(a));
            Console.ReadLine();
        }
    }

    public class DrivingDirections
    {
        public string[] reverse(string[] directions)
        {
            List<string> dirs = new List<string>();
            string[] tempLast = directions[directions.Length - 1].Split(' ');
            dirs.Add(string.Join(" ", "Start on", string.Join(" ", tempLast.Skip(3).Take(tempLast.Length - 3).ToArray())));
            if (directions.Length == 1)
                return directions;
            for (int i = directions.Length - 1; i > 0; i--)
            {
                string[] temp = directions[i].Split(' ');
                string[] tempAnt = directions[i - 1].Split(' ');
                if (temp[1] == "RIGHT")
                    dirs.Add((i - 1 == 0) ? string.Join(" ", "Turn LEFT on", string.Join(" ", tempAnt.Skip(2).Take(tempAnt.Length - 2).ToArray())) : string.Join(" ", "Turn LEFT on", string.Join(" ", tempAnt.Skip(3).Take(tempAnt.Length - 3).ToArray())));
                else
                    dirs.Add((i - 1 == 0) ? string.Join(" ", "Turn RIGHT on", string.Join(" ", tempAnt.Skip(2).Take(tempAnt.Length - 2).ToArray())) : string.Join(" ", "Turn LEFT on", string.Join(" ", tempAnt.Skip(3).Take(tempAnt.Length - 3).ToArray())));
            }
            return dirs.ToArray();
        }
    }
}
