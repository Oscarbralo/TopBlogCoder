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
            ExerciseMachine x = new ExerciseMachine();
            Console.WriteLine(x.getPercentages("00:30:00"));
            Console.ReadLine();
        }
    }

    public class ExerciseMachine
    {
        public int getPercentages(string time)
        {
            int res = 0;
            double temp = 0.0;
            string[] secs = time.Split(':');
            double sec = (double.Parse(secs[0]) * 3600.0) + (double.Parse(secs[1]) * 60.0) + double.Parse(secs[2]);
            for (int i = 1; i < sec; i++)
            {
                temp = ((double)i * 100.0) / sec;
                if (!(temp.ToString().Contains(",")))
                    res++;
            }
            return res;
        }
    }
}
