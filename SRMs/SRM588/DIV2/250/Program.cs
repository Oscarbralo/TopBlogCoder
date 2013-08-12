using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyDungeonDiv2 x = new KeyDungeonDiv2();
            int[] a = { 0,0,0 };
            int[] b = { 0,0,0 };
            int[] c = { 2, 3, 1 };
            Console.WriteLine(x.countDoors(a,b,c));
            Console.ReadLine();
        }
    }

    public class KeyDungeonDiv2
    {
        public int countDoors(int[] doorR, int[] doorG, int[] keys)
        {
            int result = 0;
            for (int i = 0; i < doorR.Length; i++)
            {
                int white = keys[2];
                doorR[i] -= keys[0];
                doorG[i] -= keys[1];
                while (doorR[i] > 0 && white > 0)
                {
                    doorR[i]--;
                    white--;
                }
                while (doorG[i] > 0 && white > 0)
                {
                    doorG[i]--;
                    white--;
                }
                if (doorR[i] <= 0 && doorG[i] <= 0)
                    result++;
            }
            return result;
        }
    }
}
