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
            BusinessTasks x = new BusinessTasks();
            string[] a = { "a", "b", "c", "d", "e" };
            Console.WriteLine(x.getTask(a, 3));
            Console.ReadLine();
        }
    }

    public class BusinessTasks
    {
        public string getTask(string[] list, int n)
        {
            n--;
            List<string> tasks = list.ToList();
            int current = 0;
            while (tasks.Count > 1)
            {
                current = (current + n) % tasks.Count;
                tasks.RemoveAt(current);
            }
            return tasks[0];
        }
    }
}
