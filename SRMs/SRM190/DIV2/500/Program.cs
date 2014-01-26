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
            Hangman x = new Hangman();
            string[] a = { "BRINGS", "BARBED", "BUBBLE" };
            Console.WriteLine(x.guessWord("B--B--", a));
            Console.ReadLine();
        }
    }

    public class Hangman
    {
        public string guessWord(string feedback, string[] words)
        {
            string result = "";
            int lettersInFeedback = feedback.Count(x => x != '-');
            List<string> list = new List<string>();
            string[] newWords = words.Select(x => x).Where(x => x.Length == feedback.Length).ToArray<string>();
            for (int i = 0; i < newWords.Length; i++)
            {
                int count = 0;
                for (int a = 0; a < newWords[i].Length; a++)
                {
                    if (feedback[a] != '-')
                    {
                        if (newWords[i][a] == feedback[a])
                            count++;
                        else
                            break;
                    }
                }
                if (count == lettersInFeedback)
                    list.Add(newWords[i]);
            }
            for (int i = 0; i < feedback.Length; i++)
            {
                if (feedback[i] != '-')
                {
                    int count = feedback.Count(x => x == feedback[i]);
                    for (int a = 0; a < list.Count; a++)
                    {
                        int temp = list[a].Count(x => x == feedback[i]);
                        if (temp != count)
                        {
                            list.RemoveAt(a);
                            a--;
                        }
                    }
                }
            }
            if (list.Count != 1)
                return result;
            else
                return list[0];
        }
    }
}
