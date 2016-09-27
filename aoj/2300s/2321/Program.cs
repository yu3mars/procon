using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2321
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                int[,] dp = new int[n + 1, (1 << 16) + 1];
                for (int guy = 0; guy < n; guy++)
                {
                    int[] ml = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    int m = ml[0];
                    int l = ml[1];
                    int nowtime = 0;
                    for (int i = 0; i < m; i++)
                    {
                        int[] se = Console.ReadLine().Split().Select(int.Parse).ToArray();
                        for (int j = se[0]; j < se[1]; j++)
                        {
                            nowtime |= (1 << (j - 6));
                        }
                    }
                    for (int time = 0; time < (1 << 16); time++)
                    {
                        dp[guy + 1, time] = Math.Max(
                           dp[guy + 1, time], dp[guy, time]);
                    }
                    for (int time = 0; time < (1 << 16); time++)
                    {

                        if ((nowtime & time) == 0)
                        {
                            dp[guy + 1, nowtime | time] = Math.Max(
                                dp[guy + 1, nowtime | time],
                                dp[guy, time] + l
                                );
                        }
                    }
                }
                int ans = 0;
                for (int i = 0; i < (1 << 16); i++)
                {
                    ans = Math.Max(ans, dp[n, i]);
                }
                Console.WriteLine(ans);
            }
        }


    }
}
