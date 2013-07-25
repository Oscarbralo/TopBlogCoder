using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _550
{
    class Program
    {
        static void Main(string[] args)
        {
            InstantRunoff x = new InstantRunoff();
            string[] a = { "JFYZARNXGL", "AXZNGFLJRY", "NGJZXFYARL", "LFZNRXYGAJ", "YGZXRFANJL", "NLFXJGARZY", "XJFAZLYGNR", "ZYJLAGFNRX", "LARGJZXFNY", "JLRZGNXAYF", "RAZFXLNYJG", "AZGNYXFLRJ", "JLZGXRYNFA", "NFJGRLZAYX", "RJLZFGAYXN", "FALXZGJNYR", "JGLAFRYZNX", "AGJXFNYLRZ", "ZAJXRGNLFY", "XJYGNAZFRL", "RZLJNGYAXF", "ZRNAYFLJXG", "GZNXYFRJLA", "YXLJAGZFRN", "NJXYRAGFZL", "YLAZFXJNGR", "ZYRJFXGNAL", "RYNGJAFXLZ", "LFAGZYJNXR", "RLZAYXGFNJ", "XZAFLNJRGY", "YJLGAFRZXN", "JNARFGZXYL", "NFGRALZJYX", "ZYXRJFAGLN", "RLJGXYNZFA", "XFNJAZGLYR", "JZXGLFNYAR", "FXRZJGLANY", "JGAFRZYNLX", "NZYLARXGJF", "ZRYJLGAFXN", "LGAXYFZNJR" };
            Console.WriteLine(x.outcome("JRXLFNYGZA", a));
            Console.ReadLine();
        }
    }

    public class InstantRunoff
    {
        public string outcome(string candidates, string[] ballots)
        {
            if (candidates.Length == 1)
                return candidates;
            while(candidates.Length > 1)
            {
                int[] abc = new int[candidates.Length];
                for (int a = 0; a < ballots.Length; a++)
                {
                    if (ballots[a].Length > 0)
                    {
                        if (candidates.Contains(ballots[a][0].ToString()))
                            abc[candidates.IndexOf(ballots[a][0].ToString())]++;
                    }
                }
                int indexMin = 99;
                int index = 0;
                for (int c = 0; c < abc.Length; c++)
                {
                    if (abc[c] < indexMin)
                    {
                        indexMin = abc[c];
                        index = c;
                    }
                }
                for (int d = abc.Length - 1; d >= 0; d--)
                {
                    if (abc[d] == indexMin)
                    {
                        string letter = candidates[d].ToString();
                        candidates = candidates.Remove(d, 1);
                        for (int j = 0; j < ballots.Length; j++)
                        {
                            if (ballots[j].Contains(letter))
                                ballots[j] = ballots[j].Remove(ballots[j].IndexOf(letter), 1);
                        }
                    }
                }
                if (candidates.Length == 0)
                    return "";
            }
            return candidates;
        }
    }
}
