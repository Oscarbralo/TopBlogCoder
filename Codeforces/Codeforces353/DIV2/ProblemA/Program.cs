using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A.Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieces = int.Parse(Console.ReadLine());
            string[] temp = new string[pieces];
            int left = 0;
            int right = 0;
            for (int i = 0; i < pieces; i++)
            {
                temp[i] = Console.ReadLine();
                left += int.Parse(temp[i][0].ToString());
                right += int.Parse(temp[i][2].ToString());
            }
            bool finish = false;
            if (left % 2 == 0 && right % 2 == 0)
                Console.WriteLine(0);
            else
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    int resLeft = left;
                    int resRight = right;
                    resLeft -= int.Parse(temp[i][0].ToString());
                    resLeft += int.Parse(temp[i][2].ToString());
                    resRight -= int.Parse(temp[i][2].ToString());
                    resRight += int.Parse(temp[i][0].ToString());
                    if (resLeft % 2 == 0 && resRight % 2 == 0)
                    {
                        finish = true;
                        break;
                    }
                }
                if (finish)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(-1);
            }
        }
    }
}
