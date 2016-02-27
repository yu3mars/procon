using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                int[] mapx = new int[n + 1];
                int[] mapy = new int[n + 1];
                int[] lim = new int[4];//ldru
                for (int i = 1; i <= n - 1; i++)
                {
                    string[] rd = Console.ReadLine().Split(' ');
                    int r = int.Parse(rd[0]);
                    int d = int.Parse(rd[1]);
                    if (d == 0)
                    {
                        mapx[i] = mapx[r] - 1;
                        mapy[i] = mapy[r];
                        lim[0] = Math.Min(lim[0], mapx[i]);
                    }
                    else if (d == 1)
                    {
                        mapx[i] = mapx[r];
                        mapy[i] = mapy[r] - 1;
                        lim[1] = Math.Min(lim[1], mapy[i]);
                    }
                    else if (d == 2)
                    {
                        mapx[i] = mapx[r] + 1;
                        mapy[i] = mapy[r];
                        lim[2] = Math.Max(lim[2], mapx[i]);
                    }
                    else if (d == 3)
                    {
                        mapx[i] = mapx[r];
                        mapy[i] = mapy[r] + 1;
                        lim[3] = Math.Max(lim[3], mapy[i]);
                    }
                }
                Console.WriteLine("{0} {1}", lim[2] - lim[0] + 1, lim[3] - lim[1] + 1);
            }
        }
    }
}
