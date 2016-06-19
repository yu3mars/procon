using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] dp = new long[n];
            dp[0] = 0;
            dp[1] = Math.Abs(a[0] - a[1]);
            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Min(dp[i - 2] + Math.Abs(a[i - 2] - a[i]),
                    dp[i - 1] + Math.Abs(a[i - 1] - a[i]));
            }
            Console.WriteLine(dp[n - 1]);
        }
    }
}
