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
            FolderSize x = new FolderSize();
            string[] a = { "0 55", "0 47", "1 86" };
            Console.WriteLine(x.calculateWaste(a, 3, 50));
            Console.ReadLine();
        }
    }

    public class FolderSize
    {
        public int[] calculateWaste(string[] files, int folderCount, int clusterSize)
        {
            int[] result = new int[folderCount];
            for (int i = 0; i < files.Length; i++)
            {
                int[] temp = files[i].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                int storageLeft = temp[1] % clusterSize;
                int storageTotal = clusterSize * (temp[1] / clusterSize);
                if (storageLeft > 0)
                    storageTotal += clusterSize;
                result[temp[0]] += (storageTotal - temp[1]);
            }
            return result;
        }
    }
}
