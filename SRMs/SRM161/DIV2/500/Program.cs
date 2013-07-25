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
            StringTrain x = new StringTrain();
            string[] a = { "A", "A", "A", "AA" };
            Console.WriteLine(x.buildTrain(a));
            Console.ReadLine();
        }
    }

    public class StringTrain
    {
        public string buildTrain(string[] cars)
        {
            string res = cars[0];
            for (int i = 1; i < cars.Length; i++)
            {
                for (int a = cars[i].Length - 1; a > 0; a--)
                {
                    string temp1 = cars[i].Substring(0, a);
                    if (temp1 == res) continue;
                    if (res.EndsWith(cars[i].Substring(0, a)))
                    {
                        res += cars[i].Substring(a, cars[i].Length - a);
                        break;
                    }
                }
            }
            string result = "";
            for (int i = res.Length - 1; i >= 0; i--)
            {
                if (!result.Contains(res[i].ToString()))
                    result = result.Insert(0, res[i].ToString());
            }
            return res.Length + " " + result;
        }
    }
}
