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
        }
    }

    public class MostProfitable
    {
        public string bestItem(int[] costs, int[] prices, int[] sales, string[] items)
        {
            string result = "";
            int temp = 0;
            int[] res = new int[costs.Length];
            for (int i = 0; i < costs.Length; i++)
            {
                res[i] = (prices[i] - costs[i]) * sales[i];
                if (res[i] > temp && res[i] > 0)
                {
                    result = items[i];
                    temp = res[i];
                }
            }
            return result;
        }
    }
}
