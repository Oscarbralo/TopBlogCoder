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
            DVDPlayer x = new DVDPlayer();
            string[] a = { "a", "x", "a", "y", "a", "z", "a" };
            Console.WriteLine(x.findMovies(a));
            Console.ReadLine();
        }
    }

    public class DVDPlayer
    {
        public string[] findMovies(string[] moviesWatched)
        {
            string dvd = moviesWatched[0];
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < moviesWatched.Length; i++)
            {
                if (!dic.ContainsKey(moviesWatched[i]))
                    dic.Add(moviesWatched[i], moviesWatched[i]);
            }
            dic[dvd] = string.Empty;
            for (int i = 1; i < moviesWatched.Length; i++)
            {
                dic[dvd] = dic[moviesWatched[i]];
                dic[moviesWatched[i]] = string.Empty;
                dvd = moviesWatched[i];
            }
            dic = dic.Where(x => !string.IsNullOrEmpty(x.Value) && x.Value != x.Key).OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            string[] res = new string[dic.Count];
            int j = 0;
            foreach(KeyValuePair<string, string> d in dic)
            {
                res[j] = string.Format("{0} is inside {1}'s case", d.Key, d.Value);
                j++;
            }
            return res;
        }
    }
}
