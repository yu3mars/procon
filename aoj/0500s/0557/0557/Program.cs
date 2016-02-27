using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0557
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] ls = new int[n];
            for (int i = 0; i < n; i++)
            {
                ls[i] = int.Parse(s[i]);
            }
            long[,] dp = new long[n, 21];
            dp[1, ls[0]] = 1;
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (j + ls[i] <= 20)
                    {
                        dp[i + 1, j + ls[i]] += dp[i, j];
                    }
                    if (j - ls[i] >= 0)
                    {
                        dp[i + 1, j - ls[i]] += dp[i, j];                        
                    }
                }
            }
            Console.WriteLine(dp[n - 1, ls[n - 1]]);
        }
    }
}
