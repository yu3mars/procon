using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPL_1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int w = int.Parse(str[1]);
            int[,] dp = new int[n + 2, w + 2];
            int[] val = new int[n + 1];
            int[] weight = new int[n + 1];
            int maxvalue = 0;
            for (int i = 1; i <= n; i++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                val[i] = int.Parse(str2[0]);
                weight[i] = int.Parse(str2[1]);
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= w; j++)
                {
                    dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j]);
                    maxvalue = Math.Max(maxvalue, dp[i + 1, j]);
                    if (j + weight[i] <= w)
                    {
                        dp[i + 1, j + weight[i]] = Math.Max
                            (dp[i + 1, j + weight[i]], dp[i, j] + val[i]);
                        maxvalue = Math.Max(maxvalue, dp[i + 1, j + weight[i]]);
                    }
                    dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j]);
                    maxvalue = Math.Max(maxvalue, dp[i + 1, j]);
                }
            }
            Console.WriteLine(maxvalue);
        }
    }
}
