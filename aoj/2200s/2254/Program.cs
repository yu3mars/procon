using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2254
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                int[][] t = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    t[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
                }
                int[] dp = new int[1 << (n)];
                for (int i = 0; i < dp.Length; i++)
                {
                    dp[i] = int.MaxValue / 3;
                }
                dp[0] = 0;
                
                for (int bitcnt = 0; bitcnt < n; bitcnt++)
                {
                    for (int bitnow = 0; bitnow < (1 << n); bitnow++)
                    {
                        if (bitcnt != bitCount(bitnow)) continue;
                        
                        for (int next = 0; next < n; next++)
                        {
                            int nextbit = 1 << next;
                            if ((bitnow & nextbit) == 0)
                            {
                                int time = t[next][0];

                                for (int itemuse = 0; itemuse < n; itemuse++)
                                {
                                    if ((bitnow & (1 << itemuse)) > 0)
                                    {
                                        time = Math.Min(time, t[next][itemuse + 1]);
                                    }
                                }
                                dp[bitnow | nextbit] = Math.Min(dp[bitnow | nextbit], dp[bitnow] + time);

                            }
                        }
                    }
                }
                Console.WriteLine(dp[(1 << n) - 1]);
            }
        }

        static int bitCount(long x)
        {
            x = (x & 0x5555555555555555) + (x >> 1 & 0x5555555555555555);
            x = (x & 0x3333333333333333) + (x >> 2 & 0x3333333333333333);
            x = (x & 0x0f0f0f0f0f0f0f0f) + (x >> 4 & 0x0f0f0f0f0f0f0f0f);
            x = (x & 0x00ff00ff00ff00ff) + (x >> 8 & 0x00ff00ff00ff00ff);
            x = (x & 0x0000ffff0000ffff) + (x >> 16 & 0x0000ffff0000ffff);
            return (int)((x & 0x00000000ffffffff) + (x >> 32 & 0x00000000ffffffff));
        }


    }
}
