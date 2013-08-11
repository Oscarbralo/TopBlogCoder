using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _450
{
    class Program
    {
        static void Main(string[] args)
        {
            HuffmanDecoding x = new HuffmanDecoding();
            string[] a = { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" };
            Console.WriteLine(x.decode("001101100101100110111101011001011001010",a));
            Console.ReadLine();
        }
    }

    public class HuffmanDecoding
    {
        public string decode(string archive, string[] dictionary)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder sb = new StringBuilder(archive);
            string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < archive.Length; i++)
            {
                for (int a = 0; a < dictionary.Length; a++)
                {
                    if (sb.ToString().StartsWith(dictionary[a]))
                    {
                        result.Append(ABC[a]);
                        sb.Remove(0, dictionary[a].Length);
                        break;
                    }
                }
            }
            return result.ToString();
        }
    }
}
