using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _500
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class WordCompositionGame
    {
        public string score(string[] listA, string[] listB, string[] listC)
        {
            List<string> listaA = new List<string>();
            for (int i = 0; i < listA.Length; i++)
                listaA.Add(listA[i]);
            List<string> listaB = new List<string>();
            for (int i = 0; i < listB.Length; i++)
                listaB.Add(listB[i]);
            List<string> listaC = new List<string>();
            for (int i = 0; i < listC.Length; i++)
                listaC.Add(listC[i]);
            int playerA = 0;
            int playerB = 0;
            int playerC = 0;
            for (int i = 0; i < listaA.Count; i++)
            {
                int temp = 0;
                if (listaB.Contains(listaA[i]))
                    temp++;
                if (listaC.Contains(listaA[i]))
                    temp++;
                if (temp == 0)
                    playerA += 3;
                else if (temp == 1)
                    playerA += 2;
                else
                    playerA++;
            }
            for (int i = 0; i < listaB.Count; i++)
            {
                int temp = 0;
                if (listaA.Contains(listaB[i]))
                    temp++;
                if (listaC.Contains(listaB[i]))
                    temp++;
                if (temp == 0)
                    playerB += 3;
                else if (temp == 1)
                    playerB += 2;
                else
                    playerB++;
            }
            for (int i = 0; i < listaC.Count; i++)
            {
                int temp = 0;
                if (listaA.Contains(listaC[i]))
                    temp++;
                if (listaB.Contains(listaC[i]))
                    temp++;
                if (temp == 0)
                    playerC += 3;
                else if (temp == 1)
                    playerC += 2;
                else
                    playerC++;
            }
            return playerA.ToString() + "/" + playerB.ToString() + "/" + playerC.ToString();
        }
    }
}
