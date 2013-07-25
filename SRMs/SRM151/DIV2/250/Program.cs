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
            PrefixCode p = new PrefixCode();
            string[] a = { "T5Cia72L", "4k", "UAGi", "hbhxDT", "ZmRF", "MeWRoEztGK", "I2x", "C", "Ty", "I2", "UAG", "I", "MeWR" };
            Console.WriteLine(p.isOne(a));
            Console.ReadLine();
        }
    }

    public class PrefixCode
    {
        public string isOne(string[] words)
        {
            string res = "Yes";
            if (words.Length == 1)
                return "Yes";
            else
            {   
                for (int i = 0; i < words.Length; i++)
                {
                    for (int a = 0; a < words.Length; a++)
                    {
                        if (a == i)
                            continue;
                        else
                        {
                            if (words[a].StartsWith(words[i]))
                            {
                                res = "No, " + i.ToString();
                                break;
                            }
                        }
                    }
                    if (res != "Yes")
                        break;
                }
            }
            return res;
        }
    }
}
