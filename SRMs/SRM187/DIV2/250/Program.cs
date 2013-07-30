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

    public class OfficeParking
    {
        public int spacesUsed(string[] events)
        {
            int result = 0;
            IEnumerable<string> list = events.Select(x => x)..Where(x => x.Split(' ')[1].Contains("arrives"));
            int max = 0;
            foreach (string e in events)
            {
                if (e.Split(' ')[1].Contains("arrives"))
                {
                    result += 1;
                    if (result > max)
                        max = result;
                }
                else
                    result -= 1;
            }
            return max;
        }
    }
}
