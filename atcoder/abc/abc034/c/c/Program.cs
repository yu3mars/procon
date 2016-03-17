using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wh = Console.ReadLine().Split(' ');
            int w = int.Parse(wh[0]);
            int h = int.Parse(wh[1]);
            long mod = 1000000007;
            long[,] map = new long[w + 1, h + 1];
            map[0, 0] = 1;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    map[i + 1, j] += map[i, j] % mod;
                    map[i, j + 1] += map[i, j] % mod;
                }
            }
            Console.WriteLine(map[w - 1, h - 1] % mod);
        }
    }
}
