using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _550
{
    class Program
    {
        static void Main(string[] args)
        {
            BridgeSort x = new BridgeSort();
            Console.WriteLine(x.sortedHand("HAH2H3C4D5ST" ));
            Console.ReadLine();
        }
    }

    public class BridgeSort
    {
        public string sortedHand(string hand)
        {
            List<string> clubs = new List<string>();
            List<string> diamonds = new List<string>();
            List<string> hearts = new List<string>();
            List<string> spades = new List<string>();
            for (int i = 0; i < hand.Length; i += 2)
            {
                string temp = hand.Substring(i, 2);
                temp = temp.Replace("T", "990");
                temp = temp.Replace("J", "991");
                temp = temp.Replace("Q", "992");
                temp = temp.Replace("K", "993");
                temp = temp.Replace("A", "994");
                switch (temp[0])
                {
                    case 'C':
                        clubs.Add(temp);
                        break;
                    case 'D':
                        diamonds.Add(temp);
                        break;
                    case 'H':
                        hearts.Add(temp);
                        break;
                    case 'S':
                        spades.Add(temp);
                        break;
                }
            }
            string[] cl = clubs.OrderBy(x => x).ToArray<string>();
            string[] di = diamonds.OrderBy(x => x).ToArray<string>();
            string[] he = hearts.OrderBy(x => x).ToArray<string>();
            string[] sp = spades.OrderBy(x => x).ToArray<string>();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Join("", cl));
            sb.Append(string.Join("", di));
            sb.Append(string.Join("", he));
            sb.Append(string.Join("", sp));
            sb = sb.Replace("990", "T");
            sb = sb.Replace("991", "J");
            sb = sb.Replace("992", "Q");
            sb = sb.Replace("993", "K");
            sb = sb.Replace("994", "A");
            return sb.ToString();
        }
    }
}
