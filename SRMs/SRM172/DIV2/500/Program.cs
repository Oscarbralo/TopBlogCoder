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
            BadClock x = new BadClock();
            Console.WriteLine(x.nextAgreement("03:19:53", "03:02:36", 1148));
            Console.ReadLine();
        }
    }

    public class BadClock
    {
        public double nextAgreement(string trueTime, string skewTime, int hourlyGain)
        {
            string[] hour1 = trueTime.Split(':');
            string[] hour2 = skewTime.Split(':');
            double result = 0.0;
            double hour1Total = (double.Parse(hour1[0]) * 3600) + (double.Parse(hour1[1]) * 60) + double.Parse(hour1[2]);
            double hour2Total = (double.Parse(hour2[0]) * 3600) + (double.Parse(hour2[1]) * 60) + double.Parse(hour2[2]);
            if (hour1Total != hour2Total && hourlyGain < 0)
            {
                if (hour2Total < hour1Total)
                    hour2Total += (12 * 3600);
                double diff = hour2Total - hour1Total;
                double hourly = hourlyGain * -1;
                result = diff / hourly;
            }
            else if (hour1Total != hour2Total && hourlyGain > 0)
            {
                if (hour1Total < hour2Total)
                    hour1Total += (12 * 3600);
                double diff = hour1Total - hour2Total;
                result = diff / hourlyGain;
            }
            return result;
        }
    }
}
