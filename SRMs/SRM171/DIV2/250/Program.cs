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
            RPG x = new RPG();
            string[] a = { "3d6" };
            Console.WriteLine(x.dieRolls(a));
            Console.ReadLine();
        }
    }

    public class RPG
    {
        public int[] dieRolls(string[] dice)
        {
            int[] res = new int[3];
            for (int i = 0; i < dice.Length; i++)
            {
                string[] temp = dice[i].Split('d');
                res[0] += int.Parse(temp[0]);
                res[1] += int.Parse(temp[0]) * int.Parse(temp[1]);
            }
            res[2] = (res[0] + res[1]) / 2;
            return res;
        }
    }
}
