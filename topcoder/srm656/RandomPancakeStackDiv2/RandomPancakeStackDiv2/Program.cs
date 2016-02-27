using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomPancakeStackDiv2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class RandomPancakeStackDiv2
    {
        public static double expectedDeliciousness(int[] d)
        {
            int n = d.Length;
            double[,] dp = new double[n, n];
            double ans = 0;
            for (int j = 0; j < n; j++)
            {
                dp[0, j] = (double)1 / n;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        dp[i, j] += dp[i - 1, k] / (n - i);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans += dp[i, j] * d[j];
                }
            }
            return ans;
        }
    }
}
