using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM296
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class DollSets
    {
        public int maximumQuantity(int[] dollSizes, int K)
        {
            Array.Sort(dollSizes);
            int result = 0;
            for (int i = 0; i < dollSizes.Length; i++)
            {
                for (int a = dollSizes.Length - 1; a >= 0; a--)
                {
                    if (a == i)
                        continue;
                    else
                    {
                        if (dollSizes[i] * K == dollSizes[a] || dollSizes[a] * K == dollSizes[i])
                        {
                            if (dollSizes[i] == -1000 || dollSizes[a] == -1000)
                                continue;
                            result++;
                            dollSizes[a] = -1000;
                            dollSizes[i] = -1000;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
