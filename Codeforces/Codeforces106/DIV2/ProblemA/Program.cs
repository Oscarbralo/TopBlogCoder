using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string suit = Console.ReadLine();
            string[] cards = Console.ReadLine().Split(' ');
            string deck = "6789TJQKA";
            if (cards[0][1].ToString() == suit && cards[1][1].ToString() != suit)
                Console.WriteLine("YES");
            else if(cards[0][1] == cards[1][1] && deck.IndexOf(cards[0][0].ToString()) > deck.IndexOf(cards[1][0].ToString()))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
