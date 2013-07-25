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
            Sets x = new Sets();
            int[] a = { 6, 5, 7, 4 };
            int[] b = { 7, 6, 4, 10 };
            Console.WriteLine(x.operate(a, b, "SYMMETRIC DIFFERENCE"));
            Console.ReadLine();
        }
    }

    public class Sets
    {
        public int[] operate(int[] A, int[] B, string operation)
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            Queue<int> queue = new Queue<int>();
            switch (operation)
            {
                case "UNION":
                    for (int i = 0; i < A.Length; i++)
                        list.Add(A[i]);
                    for (int i = 0; i < B.Length; i++)
                    {
                        if (!(list.Contains(B[i])))
                            list.Add(B[i]);
                    }
                    break;
                case "INTERSECTION":
                    for (int i = 0; i < A.Length; i++)
                        queue.Enqueue(A[i]);
                    for (int i = 0; i < B.Length; i++)
                        queue.Enqueue(B[i]);
                    while (queue.Count > 0)
                    {
                        int temp = queue.Dequeue();
                        if (queue.Contains(temp) && !(list.Contains(temp)) && !(list2.Contains(temp)))
                            list.Add(temp);
                        else
                            list2.Add(temp);
                    }
                    break;
                case "SYMMETRIC DIFFERENCE":
                    for (int i = 0; i < A.Length; i++)
                        queue.Enqueue(A[i]);
                    for (int i = 0; i < B.Length; i++)
                        queue.Enqueue(B[i]);
                    while (queue.Count > 0)
                    {
                        int temp = queue.Dequeue();
                        if (!queue.Contains(temp) && !(list.Contains(temp)) && !(list2.Contains(temp)))
                            list.Add(temp);
                        else
                            list2.Add(temp);
                    }
                    break;
            }
            int[] result = list.ToArray();
            Array.Sort(result);
            return result;
        }
    }
}
