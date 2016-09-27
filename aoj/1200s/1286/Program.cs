using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1286
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                int[] nmk = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = nmk[0];
                int m = nmk[1];
                int k = nmk[2];
                if (n == 0) return;

                double[,] dp = new double[n + 1, n * (m + 1)];
                dp[0, 0] = 1;
                for (int dice = 0; dice < n; dice++)
                {
                    for (int val = 0; val < n*m+1; val++)
                    {
                        if(dp[dice,val]>0)
                        {
                            for (int diceval = 1; diceval <= m; diceval++)
                            {
                                dp[dice + 1, val + diceval] += dp[dice, val] / m;
                            }
                        }
                    }
                }
                double ans = 0;
                for (int i = 0; i < n*m+1; i++)
                {
                    if(i<=k)
                    {
                        ans += dp[n, i];
                    }
                    else
                    {
                        ans += dp[n, i] * (i - k);
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
