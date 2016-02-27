using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            int[] a = new int[n];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                a[i] = int.Parse(str[0]);
                b[i] = int.Parse(str[1]);
            }
            int[, ,] dp = new int[w + 2, n + 2, k + 2];
            int maxvalue = 0;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        if (i + a[j] <= w)
                        {
                            dp[i + a[j], j + 1, l + 1] =
                                Math.Max(dp[i + a[j], j + 1, l], dp[i, j, l] + b[j]);
                            maxvalue = Math.Max(maxvalue, dp[i + a[j], j + 1, l + 1]);
                        }
                    }
                }
            }
            
            Console.WriteLine(maxvalue);
        }
    }
}
