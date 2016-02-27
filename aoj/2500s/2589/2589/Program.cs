using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2589
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string dir = Console.ReadLine();
                if (dir == "#")
                {
                    return;
                }

                int u = 90;
                int d = 1;
                int cnt = 0;
                for (int i = dir.Length-1; i >=0; i--)
                {
                    if (dir[i] == 'n')
                    {
                        if (cnt == 0)
                        {
                            u = 0;
                        }
                        else
                        {
                            u *= 2;
                            d *= 2;
                            u -= 90;
                        }
                        cnt += 1;
                    }
                    else if (dir[i] == 'w')
                    {
                        if (cnt == 0)
                        {
                            u = 90;
                        }
                        else
                        {
                            u *= 2;
                            d *= 2;
                            u += 90;
                        }
                        cnt += 1;
                    }
                }
                if (cnt == 1)
                {
                    Console.WriteLine(u);
                }
                else if (d == 2)
                {
                    Console.WriteLine(u / 2);
                }
                else
                {
                    Console.WriteLine("{0}/{1}", u / 2, d / 2);
                }
            }
        }
    }
}
