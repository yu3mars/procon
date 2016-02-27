using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1285
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nw = Console.ReadLine().Split(' ');
                int n = int.Parse(nw[0]);
                int w = int.Parse(nw[1]);
                if (n == 0 && w == 0) return;

                int[] cnt = new int[15];
                int hmax = int.MinValue;
                int wmax = int.MinValue;
                double ans = 0.01;
                for (int i = 0; i < n; i++)
                {
                    int now = int.Parse(Console.ReadLine());
                    cnt[now / w] += 1;
                }
                for (int i = 0; i < cnt.Length; i++)
                {
                    hmax = Math.Max(hmax, cnt[i]);
                    if (cnt[i] > 0) wmax = Math.Max(wmax, i);
                }
                for (int i = 0; i < wmax; i++)
                {
                    ans += (double)(wmax - i) * cnt[i] / wmax / hmax;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
