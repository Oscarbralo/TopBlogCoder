using System;

namespace GeorgeAndSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hour1 = Console.ReadLine().Split(':');
            string[] hour2 = Console.ReadLine().Split(':');
            int minHour1 = int.Parse(hour1[0]) * 60 + int.Parse(hour1[1]);
            int minHour2 = int.Parse(hour2[0]) * 60 + int.Parse(hour2[1]);
            int res = minHour1 - minHour2 > 0 ? minHour1 - minHour2 : (minHour1 - minHour2) + (60 * 24);
            string H = (res / 60).ToString().Length < 2 ? "0" + (res / 60).ToString() : (res / 60).ToString() == "24" ? "00" : (res / 60).ToString();
            string M = (res % 60).ToString().Length < 2 ? "0" + (res % 60).ToString() : (res % 60).ToString();
            Console.WriteLine(string.Format("{0}:{1}", H, M));
            Console.ReadLine();
        }
    }
}
