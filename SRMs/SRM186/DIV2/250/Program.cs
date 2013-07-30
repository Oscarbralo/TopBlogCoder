using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _250
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class GolfScore
    {
        public int tally(int[] parValues, string[] scoreSheet)
        {
            int result = 0;
            for (int i = 0; i < scoreSheet.Length; i++)
            {
                switch (scoreSheet[i])
                {
                    case "triple bogey":
                        result += parValues[i] + 3;
                        break;
                    case "double bogey":
                        result += parValues[i] + 2;
                        break;
                    case "bogey":
                        result += parValues[i] + 1;
                        break;
                    case "par":
                        result += parValues[i];
                        break;
                    case "birdie":
                        result += parValues[i] - 1;
                        break;
                    case "eagle":
                        result += parValues[i] - 2;
                        break;
                    case "albatross":
                        result += parValues[i] - 3;
                        break;
                    case "hole in one":
                        result++;
                        break;
                }
            }
            return result;
        }
    }
}
