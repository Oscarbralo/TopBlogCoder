using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int hundreds = int.Parse(input[0]);
            int tens = int.Parse(input[1]);
            bool ciel = true;
            while (hundreds >= 0 && tens >= 0)
            {
                if (ciel)
                {
                    if (hundreds >= 2 && tens >= 2)
                    {
                        ciel = !ciel;
                        hundreds -= 2;
                        tens -= 2;
                    }
                    else if (hundreds >= 1 && tens >= 12)
                    {
                        ciel = !ciel;
                        hundreds -= 12;
                        tens -= 12;
                    }
                    else if (hundreds == 0 && tens >= 22)
                    {
                        ciel = !ciel;
                        tens -= 22;
                    }
                    else
                        break;
                }
                else
                {
                    if (tens >= 22)
                    {
                        ciel = !ciel;
                        tens -= 22;
                    }
                    else if (tens >= 12 && hundreds >= 1)
                    {
                        ciel = !ciel;
                        tens -= 12;
                        hundreds--;
                    }
                    else if (tens >= 2 && hundreds >= 2)
                    {
                        ciel = !ciel;
                        tens -= 2;
                        hundreds -= 2;
                    }
                    else
                        break;
                }
            }
            if(ciel)
                Console.WriteLine("hanako");
            else
                Console.WriteLine("Ciel");
            Console.ReadLine();
        }
    }
}
