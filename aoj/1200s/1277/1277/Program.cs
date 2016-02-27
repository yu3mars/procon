using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1277
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] ntlb = Console.ReadLine().Split(' ');
                n = int.Parse(ntlb[0]);
                if (n == 0) return;
                int t = int.Parse(ntlb[1]);
                int l = int.Parse(ntlb[2]);
                int b = int.Parse(ntlb[3]);

                bool[] lose = new bool[n + 1];
                bool[] back = new bool[n + 1];
                for (int i = 0; i < l; i++)
                {
                    int lin = int.Parse(Console.ReadLine());
                    lose[lin] = true;
                }
                for (int i = 0; i < b; i++)
                {
                    int bin = int.Parse(Console.ReadLine());
                    back[bin] = true;
                }
                double[,] dp = new double[t + 2, n + 1];
                dp[0, 0] = 1;

                for (int i = 0; i < t; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 1; k <= 6; k++)
                        {
                            int next = num(j + k);
                            if (lose[next])
                            {
                                dp[i + 2, next] += dp[i, j] / 6;
                            }
                            else if (back[next])
                            {
                                dp[i + 1, 0] += dp[i, j] / 6;
                            }
                            else
                            {
                                dp[i + 1, next] += dp[i, j] / 6;
                            }
                        }
                    }
                    dp[i + 1, n] += dp[i, n];
                }
                Console.WriteLine(dp[t, n].ToString("F10"));
            }
        }

        static int num(int i)
        {
            if (i > n)
            {
                return 2 * n - i;
            }
            return i;

        }
    }
}
