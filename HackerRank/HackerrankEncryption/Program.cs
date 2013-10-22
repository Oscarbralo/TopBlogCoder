using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string inp = Console.ReadLine();
        string inputWithoutSpaces = inp.Replace(" ", "");
        //Get square dimensions
        int columns = 2;
        int rows = 1;
        while (columns * rows < inputWithoutSpaces.Length)
        {
            rows++;
            if (columns * rows >= inputWithoutSpaces.Length)
                break;
            columns++;
        }
        //Add extra spaces
        int spacesToAdd = (columns * rows) - inputWithoutSpaces.Length;
        for (int i = 0; i < spacesToAdd; i++)
            inputWithoutSpaces += " ";
        //Split the word
        int x = 0;
        string[] input = new string[rows];
        for (int i = 0; i < rows; i++)
        {
            input[i] = inputWithoutSpaces.Substring(x, columns);
            x += columns;
        }
        //Encrypt
        string[] res = new string[input[0].Length];
        for (int i = 0; i < input[0].Length; i++)
        {
            for (int a = 0; a < input.Length; a++)
            {
                string temp = input[a][i].ToString();
                if (temp != " ")
                    res[i] += input[a][i].ToString();
            }
        }
        string result = string.Join(" ", res);
        Console.WriteLine(result);
    }
}
