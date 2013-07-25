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
            CardCount x = new CardCount();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class CardCount
    {
        public string[] dealHands(int numPlayers, string deck)
        {
            string[] res = new string[numPlayers];
            for (int i = 0; i < res.Length; i++)
                res[i] = "";
            int temp = deck.Length / numPlayers;
            if (deck.Length < numPlayers)
                return res;
            string temp1 = deck.Substring(0, numPlayers * temp);
            int x = 0;
            for (int i = 0; i < temp1.Length; i++)
            {
                res[x] += temp1[i].ToString();
                x++;
                if (x == numPlayers)
                    x = 0;
            }
            return res;
        }
    }
}
