using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            DinkyFish a = new DinkyFish();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class DinkyFish
    {
        public int monthsUntilCrowded(int tankVolume, int maleNum, int femaleNum)
        {
            int result = 0;
            int total = tankVolume * 2;
            int fish = maleNum + femaleNum;
            while (fish <= total)
            {
                int tot = Math.Min(maleNum, femaleNum);
                maleNum += tot;
                femaleNum += tot;
                fish = maleNum + femaleNum;
                result++;
            }
            return result;
        }
    }
}
