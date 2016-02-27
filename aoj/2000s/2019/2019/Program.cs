using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2019
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                if (n == 0 && m == 0)
                {
                    return;
                }
                int[] road = new int[11];
                int dtotal = 0;
                for (int i = 0; i < n; i++)
                {
                    string[] dp = Console.ReadLine().Split(' ');
                    int d = int.Parse(dp[0]);
                    int p = int.Parse(dp[1]);
                    road[p] += d;
                    dtotal += d;
                }
                int enc = dtotal - m;
                int ans = 0;
                if (enc < 0)
                {
                    Console.WriteLine(0);
                    continue;
                }
                for (int i = 0; i <= 10; i++)
                {
                    int hit = Math.Min(enc, road[i]);
                    ans += i * hit;
                    enc -= hit;
                    if (enc <= 0)
                    {
                        break;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
