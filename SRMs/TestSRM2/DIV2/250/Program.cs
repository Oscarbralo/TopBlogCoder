using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
            SMSLanguage x = new SMSLanguage();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class SMSLanguage
    {
        public string translate(string text)
        {
            string temp = text.ToLower().Replace(".", "").Replace(",", "").Replace("?", "").Replace("!","").Replace("and", "&").Replace("ate", "8").Replace("at", "@").Replace("you", "U");
            return temp;
        }
    }
}
