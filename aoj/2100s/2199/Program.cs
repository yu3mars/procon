using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2199
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = nm[0];
                int m = nm[1];
                if (n == 0) return;
                int[] c = new int[m];
                int[] x = new int[n];
                int max = int.MaxValue;

                for (int i = 0; i < m; i++)
                {
                    c[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    x[i] = int.Parse(Console.ReadLine());
                }

                int[,] dp = new int[n + 1, 256];    //data,value
                for (int i = 0; i < n + 1; i++)
                {
                    for (int j = 0; j < 256; j++)
                    {
                        dp[i, j] = max;
                    }
                }
                dp[0, 128] = 0;

                for (int data = 0; data < n; data++)
                {
                    for (int val = 0; val < 256; val++)
                    {
                        if (dp[data, val] == max) continue;
                        for (int code = 0; code < m; code++)
                        {
                            int nextval = round(val + c[code]);
                            int scorediff = (int)Math.Pow(x[data] - nextval, 2);
                            dp[data + 1, nextval] = Math.Min(dp[data + 1, nextval], dp[data, val] + scorediff);
                        }
                    }
                }
                int ans = max;
                for (int i = 0; i < 256; i++)
                {
                    ans = Math.Min(ans, dp[n, i]);
                }
                Console.WriteLine(ans);
            }
        }

        static int round(int n)
        {
            if (n < 0) return 0;
            if (n > 255) return 255;
            return n;
        }
    }
}
