using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) - 1;

            long[] dp = new long[n + 10];
            dp[2] = 1;
            for (int i = 3; i < n + 1; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2] + dp[i - 3]) % 10007;
            }
            Console.WriteLine(dp[n] % 10007);
        }
    }
}
