using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorrectnessAndTheLoopInvariant
{
    class Program
    {
        public static void insertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = key;
            }
            StringBuilder temp = new StringBuilder("");
            for (int x = 0; x < A.Length; x++)
            {
                temp.Append(A[x] + " ");
            }
            temp = temp.Remove(temp.Length - 1, 1);
            Console.WriteLine(temp.ToString());
        }


        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] result = new int[size];
            string[] arr = Console.ReadLine().Split(' ');
            for (int a = 0; a < arr.Length; a++)
                result[a] = int.Parse(arr[a]);
            insertionSort(result);
            Console.ReadLine();
        }
    }
}

