using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedWithCandy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cases = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            List<Candy> type00 = new List<Candy>();
            List<Candy> type11 = new List<Candy>();
            for (int i = 0; i < cases[0]; i++)
            {
                int[] temp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                if (temp[0] == 0)
                    type00.Add(new Candy
                    {
                        Height = temp[1],
                        Mass = temp[2]
                    });
                else
                {
                    type11.Add(new Candy
                    {
                        Height = temp[1],
                        Mass = temp[2]
                    });
                }
            }
            type00 = type00.OrderByDescending(x => x.Height).ThenByDescending(x => x.Mass).ToList();
            type11 = type11.OrderByDescending(x => x.Height).ThenByDescending(x => x.Mass).ToList();
            bool type = true;
            int result = 0;
            for (int b = 0; b < 2; b++)
            {
                List<Candy> type0 = new List<Candy>();
                List<Candy> type1 = new List<Candy>();
                for (int c = 0; c < type00.Count; c++)
                    type0.Add(type00[c]);
                for (int c = 0; c < type11.Count; c++)
                    type1.Add(type11[c]);
                int initialJump = cases[1];
                if (b == 1)
                    type = false;
                {
                    for (int i = 0; i < cases[0]; i++)
                    {
                        if (type)
                        {
                            if (type0.Count > 0)
                            {
                                for (int a = 0; a < type0.Count; a++)
                                {
                                    if (type0[a].Height <= initialJump)
                                    {
                                        initialJump += type0[a].Mass;
                                        type0.RemoveAt(a);
                                        type = false;
                                        break;
                                    }
                                }
                                if (type)
                                    break;
                            }

                        }
                        else
                        {
                            if (type1.Count > 0)
                            {
                                for (int a = 0; a < type1.Count; a++)
                                {
                                    if (type1[a].Height <= initialJump)
                                    {
                                        initialJump += type1[a].Mass;
                                        type1.RemoveAt(a);
                                        type = true;
                                        break;
                                    }
                                }
                                if (type == false)
                                    break;
                            }

                        }
                    }
                    result = Math.Max(result, cases[0] - (type0.Count + type1.Count));
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class Candy
    {
        public int Height { get; set; }
        public int Mass { get; set; }
    }
}
