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
            ReportAccess x = new ReportAccess();
            string[] a = { "kathy", "john", "dan", "steve", "cheryl", "tony" };
            string[] b = { "users data", "data orders", "users permissions", "system users controls", "default", "admin users" };
            string[] c = { "users" };
            Console.WriteLine(x.whoCanSee(a, b, c));
            Console.ReadLine();
        }
    }

    public class ReportAccess
    {
        public string[] whoCanSee(string[] userNames, string[] allowedData, string[] reportData)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < allowedData.Length; i++)
            {
                if (reportData.Where(x => allowedData[i].Split(' ').Contains(x)).Count() == reportData.Length)
                    result.Add(userNames[i]);
            }
            return result.OrderBy(x => x).ToArray<string>();
        }
    }
}
