using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank_Language
{
    class Program
    {
        static void Main(string[] args)
        {
            string languages = "C:CPP:JAVA:PYTHON:PERL:PHP:RUBY:CSHARP:HASKELL:CLOJURE:BASH:SCALA:ERLANG:CLISP:LUA:BRAINFUCK:JAVASCRIPT:GO:D:OCAML:R:PASCAL:SBCL:DART:GROOVY:OBJECTIVEC";
            string[] l = languages.Split(':');
            int cases = int.Parse(Console.ReadLine());
            for (int a = 0; a < cases; a++)
            {
                bool x = false;
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < l.Length; i++)
                {
                    if (l[i].Length == input[1].Length)
                    {
                        Regex r = new Regex(l[i]);
                        if (r.IsMatch(input[1]))
                        {
                            Console.WriteLine("VALID");
                            x = true;
                            break;
                        }
                    }
                }
                if (!x)
                    Console.WriteLine("INVALID");

            }
            Console.ReadLine();
        }
    }
}
