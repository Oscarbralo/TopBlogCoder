using System;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitsSum x = new DigitsSum();
            Console.WriteLine(x.lastDigit(12345));
            Console.ReadLine();
        }
    }

    public class DigitsSum
    {
        public int lastDigit(int n)
        {
            if(n.ToString().Length == 1)
                return n;
            while (n.ToString().Length > 1)
            {
                string temp = n.ToString();
                n = 0;
                foreach (char t in temp)
                    n += int.Parse(t.ToString());
            }
            return n;
        }
    }
}
