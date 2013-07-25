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
            ProgressBar s = new ProgressBar();
            int[] a = { 19, 6, 23, 17 };
            Console.WriteLine(s.showProgress(a, 3));
            Console.ReadLine();
        }
    }

    public class ProgressBar
    {
        public string showProgress(int[] taskTimes, int tasksCompleted)
        {
            int sum = 0;
            string res = "";
            for (int i = 0; i < taskTimes.Length; i++)
                sum += taskTimes[i];
            int temp = 0;
            for (int i = 0; i < tasksCompleted; i++)
            {
                temp += taskTimes[i];
            }
            double temp2 = (double)temp / (double)sum;
            double temp3 = 20.0 * temp2;
            for (int i = 0; i < (int)temp3; i++)
            {
                res += "#";
            }
            while (res.Length < 20)
            {
                res += ".";
            }
            return res;
        }
    }
}
