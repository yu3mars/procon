using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1125
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
                string[] wh = Console.ReadLine().Split(' ');
                int w = int.Parse(wh[0]);
                int h = int.Parse(wh[1]);
                bool[,] tree = new bool[w + 1, h + 1];
                for (int i = 0; i < n; i++)
                {
                    string[] xy = Console.ReadLine().Split(' ');
                    int x = int.Parse(xy[0]);
                    int y = int.Parse(xy[1]);
                    tree[x, y] = true;
                }
                string[] st = Console.ReadLine().Split(' ');
                int s = int.Parse(st[0]);
                int t = int.Parse(st[1]);
                int ans = 0;
                for (int i = 1; i <= w - s + 1; i++)
                {
                    for (int j = 1; j <= h - t + 1; j++)
                    {
                        int cnt = 0;
                        for (int x = i; x < i + s; x++)
                        {
                            for (int y = j; y < j + t; y++)
                            {
                                if (tree[x, y] == true)
                                {
                                    cnt += 1;
                                }
                            }
                        }
                        ans = Math.Max(ans, cnt);
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
