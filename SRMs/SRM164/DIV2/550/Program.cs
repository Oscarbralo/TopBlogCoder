using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _550
{
    class Program
    {
        static void Main(string[] args)
        {
            PartySeats x = new PartySeats();
            string[] a = { "AM girl", "ROB boy", "JIM boy", "AM girl", "DAVE boy", "JO girl", "DAVE boy", "JO girl" };
            Console.WriteLine(x.seating(a));
            Console.ReadLine();
        }
    }

    public class PartySeats
    {
        public string[] seating(string[] attendees)
        {
            string[] res = new string[0];
            if (attendees.Length % 4 != 0)
                return res;
            List<string> boys = new List<string>();
            List<string> girls = new List<string>();
            List<string> result = new List<string>();
            for (int i = 0; i < attendees.Length; i++)
            {
                if (attendees[i].Split(' ')[1].StartsWith("b"))
                    boys.Add(attendees[i].Split(' ')[0]);
                if (attendees[i].Split(' ')[1].StartsWith("g"))
                    girls.Add(attendees[i].Split(' ')[0]);
            }
            if (boys.Count != girls.Count)
                return res;
            result.Add("HOST");
            bool x = true;
            string[] g = girls.ToArray();
            string[] b = boys.ToArray();
            Array.Sort(g);
            Array.Sort(b);
            int index = 0;
            int changes = 0;
            for (int i = 0; i < attendees.Length; i++)
            {
                if (i == attendees.Length / 2)
                {
                    result.Add("HOSTESS");
                    x = false;
                }
                if (x == true)
                {
                    x = false;
                    result.Add(g[index]);
                }
                else
                {
                    x = true;
                    result.Add(b[index]);
                }
                changes++;
                if (changes % 2 == 0)
                    index++;
            }
            return result.ToArray();
        }
    }
}
