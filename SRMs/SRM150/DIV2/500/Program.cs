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
            InterestingDigits x = new InterestingDigits();
            Console.WriteLine(x.digits(9));
            Console.ReadLine();
        }
    }

    public class InterestingDigits
    {
        public int[] digits(int basee)
        {
            List<int> list = new List<int>();
            for (int i = 2; i < basee; i++)
            {
                string temp = Math.Pow(i, basee).ToString();
                int temp1 = 0;
                for (int a = 0; a < temp.Length; a++)
                    temp1 += int.Parse(temp[a].ToString());
                double temp3 = (double)temp1 / (double)i;
                if (temp3 % i == 0)
                    list.Add(i);
            }
            return list.ToArray();
        }
    }
}
