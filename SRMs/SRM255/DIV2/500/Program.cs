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
            WordCompositionGame x = new WordCompositionGame();
            string[] a = { "cat", "dog", "pig", "mouse" };
            string[] b = { "cat", "pig" };
            string[] c = { "dog", "cat" };
            Console.WriteLine(x.score(a, b, c));
            Console.ReadLine();
        }
    }

    public class WordCompositionGame
    {
        public string score(string[] listA, string[] listB, string[] listC)
        {
            int scoresA = 0;
            for (int i = 0; i < listA.Length; i++)
            {
                if (!listB.Contains(listA[i]) && !listC.Contains(listA[i]))
                    scoresA += 3;
                else if (listB.Contains(listA[i]) && listC.Contains(listA[i]))
                    scoresA += 1;
                else if (listB.Contains(listA[i]) || listC.Contains(listA[i]))
                    scoresA += 2;
                
            }
            int scoresB = 0;
            for (int i = 0; i < listB.Length; i++)
            {
                if (!listA.Contains(listB[i]) && !listC.Contains(listB[i]))
                    scoresB += 3;
                else if (listA.Contains(listB[i]) && listC.Contains(listB[i]))
                    scoresB += 1;
                else if (listA.Contains(listB[i]) || listC.Contains(listB[i]))
                    scoresB += 2;
                
            }
            int scoresC = 0;
            for (int i = 0; i < listC.Length; i++)
            {
                if (!listA.Contains(listC[i]) && !listB.Contains(listC[i]))
                    scoresC += 3;
                else if (listA.Contains(listC[i]) && listB.Contains(listC[i]))
                    scoresC += 1;
                else if (listA.Contains(listC[i]) || listB.Contains(listC[i]))
                    scoresC += 2;
                
            }
            return string.Format(@"{0}/{1}/{2}", scoresA, scoresB, scoresC);
        }
    }
}
