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
            PartySeats x = new PartySeats();
            string[] names = { "ABC girl", "BXC boy", "ALJS girl", "SDF boy", "AEEEE boy", "ABEEE boy" };
            Console.WriteLine(string.Join(" ", x.seating(names)));
            Console.ReadLine();
        }
    }

    public class PartySeats
    {
        public string[] seating(string[] attendees)
        {
            List<string> listBoys = new List<string>();
            List<string> listGirls = new List<string>();
            for (int i = 0; i < attendees.Length; i++)
                if (attendees[i].Contains("girl"))
                    listGirls.Add(attendees[i]);
                else
                    listBoys.Add(attendees[i]);
            string[] b = listBoys.ToArray();
            string[] g = listGirls.ToArray();
            Array.Sort(b);
            Array.Sort(g);
            if ((b.Length < 2 || g.Length < 2) || (b.Length % 2 == 1 || g.Length % 2 == 1) || (b.Length != g.Length))
                return new string[0];
            string[] result = new string[b.Length + g.Length + 2];
            int tempB = 0;
            int tempG = 0;
            bool secondPart = false;
            for (int a = 0; a < b.Length + g.Length + 2; a++)
            {
                if (a == 0)
                {
                    result[0] = "HOST";
                    continue;
                }
                if (a == (b.Length + g.Length + 2) / 2)
                {
                    result[a] = "HOSTESS";
                    secondPart = true;
                    continue;
                }
                if (!secondPart)
                {
                    if (tempB == tempG)
                    {
                        result[a] = g[tempG].Split(' ')[0];
                        tempG++;
                    }
                    else
                    {
                        result[a] = b[tempB].Split(' ')[0];
                        tempB++;
                    }
                }
                else
                {
                    if (tempB == tempG)
                    {
                        result[a] = b[tempB].Split(' ')[0];
                        tempB++;
                    }
                    else
                    {
                        result[a] = g[tempG].Split(' ')[0];
                        tempG++;
                    }
                }
            }
            return result;
        }
    }
}
