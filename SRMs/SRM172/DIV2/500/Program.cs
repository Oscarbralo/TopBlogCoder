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
            BadClock x = new BadClock();
            Console.WriteLine(x.nextAgreement("03:03:48", "09:30:25", 2337));
            Console.ReadLine();
        }
    }

    public class BadClock
    {
        public double nextAgreement(string trueTime, string skewTime, int hourlyGain)
        {
            double res = 0.0;
            if (hourlyGain == 0)
                return res;
            double hour = 12.0 * 3600.0;
            string[] tr = trueTime.Split(':');
            string[] sk = skewTime.Split(':');
            double tru = (double.Parse(tr[0]) * 3600.0) + (double.Parse(tr[1]) * 60.0) + double.Parse(tr[2]);
            double ske = (double.Parse(sk[0]) * 3600.0) + (double.Parse(sk[1]) * 60.0) + double.Parse(sk[2]);
            if (hourlyGain < 0)
            {
                bool x = false;
                if (ske < tru)
                    ske += hour;
                res = 0;
                while (ske != tru)
                {
                    ske -= Math.Abs(hourlyGain);
                    res++;
                    if (ske < tru)
                        x = true;
                    if (ske < tru && x == true)
                    {
                        res--;
                        ske -= hourlyGain;
                        double xx = ske - tru;
                        res += ((xx * 100.0) / (double)Math.Abs(hourlyGain)) / 100;
                        break;
                    }
                }
            }
            else
            {
                bool x = false;
                res = 0;
                if (ske > tru)
                    ske -= hour;
                while (ske != tru)
                {
                    ske += hourlyGain;
                    res++;
                    if (ske > tru)
                    {
                        ske -= hourlyGain;
                        x = true;
                    }
                    if (ske < tru && x == true)
                    {
                        res--;
                        ske -= hourlyGain;
                        double xx = tru - ske;
                        if (xx > hourlyGain)
                        {
                            double temp1 = xx - (double)hourlyGain;
                            res += ((temp1 * 100.0) / (double)hourlyGain) / 100.0;
                            break;
                        }
                        else
                        {
                            res += ((xx * 100.0) / (double)hourlyGain) / 100.0;
                            break;
                        }
                    }
                }
            }
            return res;
        }
    }
}
