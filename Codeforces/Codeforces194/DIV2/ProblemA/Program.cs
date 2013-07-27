using System;

namespace A.Candy_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] people = new string[cases];
            int j = cases * cases;
            int x = 0;
            for (int i = 0; i < (cases * cases) / 2; i++)
            {
                people[x] += (i + 1).ToString() + " " + j.ToString() + " ";
                j--;
                x++;
                if (x == people.Length)
                    x = 0;
            }
            for (int i = 0; i < people.Length; i++)
                Console.WriteLine(people[i]);
            Console.ReadLine();
        }
    }
}
