using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            Birthday x = new Birthday();
            string[] a = { "02/17 Wernie", "10/12 Stefan" };
            Console.WriteLine(x.getNext("06/17",a));
            Console.ReadLine();
        }
    }

    public class Birthday
    {
        public string getNext(string date, string[] birthdays)
        {
            string res = "";
            int daysDate = int.Parse(date.Split('/')[0]) * 30 + int.Parse(date.Split('/')[1]);
            int maxDays = 1000;
            int days = 0;
            for (int i = 0; i < birthdays.Length; i++)
            {
                if (birthdays[i].Split(' ')[0] == date)
                    return date;
                string[] temp = birthdays[i].Split(' ')[0].Split('/');
                days = int.Parse(temp[0]) * 30 + int.Parse(temp[1]);
                if (days < daysDate)
                    days += 365;
                if (days - daysDate < maxDays)
                {
                    maxDays = days - daysDate;
                    res = birthdays[i].Split(' ')[0];
                }
            }
            return res;
        }
    }
}
