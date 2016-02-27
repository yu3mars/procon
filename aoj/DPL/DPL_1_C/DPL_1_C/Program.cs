using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPL_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int w = int.Parse(str[1]);
            int[] dp = new int[w + 2];
            int maxvalue = 0;

            for (int i = 0; i < n; i++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                int val = int.Parse(str2[0]);
                int weight = int.Parse(str2[1]);
                for (int j = 0; j+weight <= w; j++)
                {
                    dp[j + weight] = Math.Max(dp[j + weight], dp[j] + val);
                    maxvalue = Math.Max(maxvalue,dp[j+weight]);
                }
            }
            Console.WriteLine(maxvalue);
        }
    }
}
