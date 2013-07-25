using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ImageDithering
    {
        public int count(string dithered, string[] screen)
        {
            int res = 0;
            for (int b = 0; b < dithered.Length; b++)
                for (int i = 0; i < screen.Length; i++)
                    for (int a = 0; a < screen[i].Length; a++)
                        if (dithered[b].ToString() == screen[i][a].ToString())
                            res++;
            return res;
        }
    }
}
