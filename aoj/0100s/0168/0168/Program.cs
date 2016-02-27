using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0168
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int dan = int.Parse(Console.ReadLine());
                if (dan == 0)
                {
                    return;
                }
                int[] dp = new int[dan+5];
                dp[0] = 1;
                for (int i = 0; i < dan; i++)
                {
                    dp[i + 1] += dp[i];
                    dp[i + 2] += dp[i];
                    dp[i + 3] += dp[i];                    
                }
                int ans = dp[dan] / 3650;
                if (dp[dan] % 3650 <3641)
                {
                    ans += 1;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
