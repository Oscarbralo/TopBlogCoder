using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            string res = "";
            string pattern = @"[AEIOUaeiou]";
            List<int> list = new List<int>();
            Regex r = new Regex(pattern);
            foreach (Match m in r.Matches(word))
                list.Add(m.Index);
            bool x = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (!list.Contains(i))
                {
                    if (res == "")
                        res += "C";
                    else
                    {
                        if (word[i] == 'y' || word[i] == 'Y')
                        {
                            if (list.Contains(i - 1))
                            {
                                if (res[res.Length - 1] != 'C')
                                    res += "C";
                            }
                            else
                            {
                                if (res[res.Length - 1] != 'V' && x == false)
                                {
                                    res += "V";
                                    x = true;
                                    continue;
                                }
                                else
                                    res += "C";
                            }
                        }
                        else
                        {
                            if (res[res.Length - 1] != 'C')
                                res += "C";
                        }
                    }
                }
                else
                {
                    if (res == "")
                        res += "V";
                    else
                    {
                        if (res[res.Length - 1] != 'V')
                            res += "V";
                    }
                }
                x = false;
            }
            return res;
        }
    }
}
