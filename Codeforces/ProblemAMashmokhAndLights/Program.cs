using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace MashmokhAndLights
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[] lights = new int[cases[0]];
            int[] buttons = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            for (int i = 0; i < buttons.Length; i++)
            {
                for (int a = buttons[i] - 1; a < lights.Length; a++)
                {
                    if (lights[a] == 0)
                        lights[a] = buttons[i];
                }
            }
            Console.WriteLine(string.Join(" ", lights.Select(x => x.ToString())));
            Console.ReadLine();
        }
    }
}
