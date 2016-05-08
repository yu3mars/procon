using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    class Program
    {
        static int[] vy = { 1, 0, -1, 0 };
        static int[] vx = { 0, 1, 0, -1 };
        static long mod = 1000000007;


        static void Main(string[] args)
        {
            int[] hw = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int h = hw[0];
            int w = hw[1];
            long[][] map = new long[h][];
            long[][] ans = new long[h][];
            dat[] ls = new dat[h * w];
            for (int i = 0; i < h; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                //map[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
                map[i] = new long[w];
                ans[i] = new long[w];

                for (int j = 0; j < w; j++)
                {
                    map[i][j] = long.Parse(s[j]);
                    ans[i][j] = 1;
                    ls[i * w + j] = new dat(map[i][j], i, j);
                }

            }

            Array.Sort(ls, (a, b) =>
             {
                 return a.a.CompareTo(b.a);
             });
            //var ls = ls.OrderBy(p => p.a).ToArray();
            long sum = 0;

            for (int i = 0; i < ls.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int nextx = ls[i].x + vx[j];
                    int nexty = ls[i].y + vy[j];
                    if(0<=nextx && nextx < h && 0<=nexty && nexty <w)
                    {
                        if(map[nextx][nexty]< map[ls[i].x][ls[i].y])
                        {
                            ans[ls[i].x][ls[i].y] += ans[nextx][nexty];
                            ans[ls[i].x][ls[i].y] %= mod;
                        }
                    }
                }
                sum += ans[ls[i].x][ls[i].y];
                sum %= mod;
            }

            Console.WriteLine(sum % mod);
        }

        class dat
        {
            public long a;
            public int x;
            public int y;
            
            public dat(long a1,int x1,int y1)
            {
                a = a1;
                x = x1;
                y = y1;
            }            
        }
    }
}
