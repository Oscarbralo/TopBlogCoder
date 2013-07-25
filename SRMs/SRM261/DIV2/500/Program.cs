using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PrimeStatistics
    {
        public int mostCommonRemainder(int lowerBound, int upperBound, int modulo)
        {
            List<int> reminders = new List<int>();
            List<int> times = new List<int>();
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (isPrime(i) == true)
                {
                    int rem = i % modulo;
                    if (!reminders.Contains(rem))
                    {
                        reminders.Add(rem);
                        times.Add(1);
                    }
                    else
                        times[reminders.IndexOf(rem)]++;
                }
            }
            int result = 1000000;
            int resTimes = 0;
            for (int i = 0; i < times.Count; i++)
            {
                if (times[i] > resTimes)
                {
                    result = reminders[i];
                    resTimes = times[i];
                }
                else if (times[i] == resTimes && reminders[i] < result)
                {
                    result = reminders[i];
                    resTimes = times[i];
                }
            }
            if (result == 1000000)
                return 0;
            return result;
        }

        public bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int m = (int)Math.Sqrt(n);

            for (int i = 3; i <= m; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
