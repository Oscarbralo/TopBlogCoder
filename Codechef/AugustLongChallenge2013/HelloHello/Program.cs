using System;
using System.Collections.Generic;
namespace HelloHello
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int result = 0;
                string[] chef = Console.ReadLine().Split(' ');
                double moneyMin = double.Parse(chef[0]);
                double minutes = double.Parse(chef[1]);
                double plans = double.Parse(chef[2]);
                double chefMonth = minutes * moneyMin;
                double best = chefMonth;
                for (int a = 0; a < plans; a++)
                {
                    string[] plan = Console.ReadLine().Split(' ');
                    double planTotalCost = double.Parse(plan[2]);
                    double numberMonths = double.Parse(plan[0]);
                    double x = double.Parse(plan[1]);
                    double planMonth = x * minutes;
                    double monthly = planTotalCost / numberMonths;
                    double temp = planMonth + monthly;
                    if (temp < best)
                    {
                        result = a + 1;
                        best = temp;
                    }
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}