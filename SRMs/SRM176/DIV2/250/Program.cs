using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            RGBColor a = new RGBColor();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class RGBColor
    {
        public int[] getComplement(int[] rgb)
        {
            int[] rear = new int[3];
            int temp = 0;
            for (int a = 0; a < 3; a++)
            {
                rear[a] = 255 - rgb[a];
                if (Math.Abs(rear[a] - rgb[a]) <= 32)
                    temp++;
            }
            if (temp == 3)
            {
                for (int a = 0; a < 3; a++)
                {
                    if (rgb[a] < 128)
                        rear[a] = rgb[a] + 128;
                    else
                        rear[a] = rgb[a] - 128;
                }
            }
            return rear;
        }
    }
}
