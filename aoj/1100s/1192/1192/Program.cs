using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1192
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] xys = Console.ReadLine().Split(' ');
                int x = int.Parse(xys[0]);
                int y = int.Parse(xys[1]);
                int s = int.Parse(xys[2]);
                if (x == 0 && y == 0 && s == 0)
                {
                    return;
                }
                int ans = 0;
                for (int i = 1; i < s; i++)
                {
                    for (int j = 1; j < s - 1; j++)
                    {
                        int ax = i * (100 + x) / 100;
                        int bx = j * (100 + x) / 100;
                        if (ax + bx == s)
                        {
                            int ay = i * (100 + y) / 100;
                            int by = j * (100 + y) / 100;
                            ans = Math.Max(ans, ay + by);
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
