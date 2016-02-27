using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPL_1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int pay = int.Parse(str[0]);
            int kind = int.Parse(str[1]);
            string[] coinstr = Console.ReadLine().Split(' ');
            int[] coin = new int[coinstr.Length];
            int[] dp = new int[pay + 1];
            for (int i = 0; i < kind; i++)
            {
                coin[i] = int.Parse(coinstr[i]);
            }
            for (int i = 1; i <= pay; i++)
            {
                dp[i] = 100000;
            }
            
            for (int i = 0; i < kind; i++)
            {
                for (int j = 1; j <= pay; j++)
                {
                    if (j - coin[i] >= 0)
                    {
                        dp[j] = Math.Min(dp[j], dp[j - coin[i]] + 1);
                    }
                    else
                    {
                        dp[j] = Math.Min(dp[j], dp[j - 1] + 1);

                    }
                }
            }
            Console.WriteLine(dp[pay]);
        }
    }
}
