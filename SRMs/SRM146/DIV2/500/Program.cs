using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangularGrid x = new RectangularGrid();
            Console.WriteLine(x.countRectangles(592, 964));
            Console.ReadLine();
        }
    }

    public class RectangularGrid
    {
        public long countRectangles(int width, int height)
        {
            long res = 0;
            int tempWidth = 1;
            for (int i = width; i > 0; i--)
            {
                int tempHeight = 1;
                for (int a = height; a > 0; a--)
                {
                    if (i == a)
                    {
                        tempHeight++;
                        continue;
                    }
                    res += tempHeight * tempWidth;
                    tempHeight++;
                }
                tempWidth++;
            }
            return res;
        }
    }
}
