using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\GCJ\B-large.in");
            StreamWriter sw = new StreamWriter(@"C:\GCJ\B-OutputLarge.txt");
            string line = string.Empty;
            int cases = int.Parse(sr.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                double cookiesPerSecond = 2.0;
                string[] text = sr.ReadLine().Split(' ').Select(x => x.Replace('.', ',')).ToArray<string>();
                double[] input = new double[3];
                for (int a = 0; a < text.Length; a++)
                    input[a] = Convert.ToDouble(text[a]);
                double costOfFarm = input[0];
                double totalTempTime = 0.0;
                List<double> times = new List<double>();
                double farmsLeft = input[2] / costOfFarm;
                for (int a = 0; a < 200000; a++)
                {
                    double timeToFarm = costOfFarm / cookiesPerSecond;
                    times.Add(totalTempTime + (timeToFarm * farmsLeft));
                    totalTempTime += timeToFarm;
                    double leftTimeCookies = (input[2] / cookiesPerSecond) + totalTempTime;
                    times.Add(leftTimeCookies);
                    cookiesPerSecond += input[1];
                }
                string result = Convert.ToString(times.Min()).Replace(',', '.');
                sw.WriteLine(string.Format("Case #{0}: {1}", i + 1, result));
            }
            sr.Close();
            sw.Close();
        }
    }
}
