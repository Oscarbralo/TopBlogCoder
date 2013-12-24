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
            WordForm x = new WordForm();
            Console.WriteLine(x.getSequence("AyYyEYye"));
            Console.ReadLine();
        }
    }

    public class WordForm
    {
        public string getSequence(string word)
        {
            Regex r = new Regex("[aeiouAEIOUyY]");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'Y' || word[i] == 'y')
                {
                    if (i == 0)
                    {
                        if (word[i] == 'Y' || word[i] == 'y')
                        {
                            word = word.Insert(i, "C");
                            word = word.Remove(i + 1, 1);
                        }
                    }
                    else
                    {
                        if (r.IsMatch(word[i - 1].ToString()))
                        {
                            word = word.Insert(i, "C");
                            word = word.Remove(i + 1, 1);
                            i--;
                        }
                    }
                }
            }
            StringBuilder sb = new StringBuilder(" ");
            for (int i = 0; i < word.Length; i++)
            {
                if (r.IsMatch(word[i].ToString()))
                {
                    if (sb[sb.Length - 1] != 'V')
                        sb.Append("V");
                }
                else
                    if (sb[sb.Length - 1] != 'C')
                        sb.Append("C");
            }
            sb = sb.Remove(0, 1);
            return sb.ToString();
        }
    }
}
