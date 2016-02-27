using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2565
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int cnt = int.Parse(Console.ReadLine());
                if (cnt == 0) return;
                string[] s = Console.ReadLine().Split(' ');
                int small = -1000000010;
                int large = 1000000010;
                bool none = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == "x")
                    {
                        if (i != 0)
                        {
                            if (i % 2 == 0)
                            {
                                large = Math.Min(large, int.Parse(s[i - 1]));
                            }
                            else
                            {
                                small = Math.Max(small, int.Parse(s[i - 1]));
                            }
                        }
                        if (i != s.Length - 1)
                        {
                            if (s[i + 1] == "x")
                            {
                                none = true;
                                break;
                            }
                            else
                            {
                                if (i % 2 == 0)
                                {
                                    large = Math.Min(large, int.Parse(s[i + 1]));
                                }
                                else
                                {
                                    small = Math.Max(small, int.Parse(s[i + 1]));
                                }
                            }
                        }
                    }
                    else
                    {
                        if (i != 0)
                        {
                            if (s[i - 1] != "x")
                            {
                                if (i % 2 == 0)
                                {
                                    if (int.Parse(s[i - 1]) <= int.Parse(s[i]))
                                    {
                                        none = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (int.Parse(s[i - 1]) >= int.Parse(s[i]))
                                    {
                                        none = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (none == true)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    int d = large - small;
                    if (d == 2) Console.WriteLine(small + 1);
                    else if (d < 2) Console.WriteLine("none");
                    else Console.WriteLine("ambiguous");
                }
            }
        }
    }
}
