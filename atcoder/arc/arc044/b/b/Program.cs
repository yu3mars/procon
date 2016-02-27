using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] astr = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            int amax = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
                amax = Math.Max(amax, a[i]);
            }

            int[] cnt = new int[amax + 1];
            for (int i = 0; i < n; i++)
            {
                cnt[a[i]] += 1;
            }
            if (a[0] != 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (cnt[0] > 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < amax; i++)
            {
                if (cnt[i] == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            long ans = 1;
            for (int i = 1; i <= amax; i++)
            {
                ans *= ((((long)Math.Pow(2, cnt[i - 1]) - 1) % 1000000007) * cnt[i] % 1000000007)
                    * ((long)Math.Pow(2, cnt[i]));
                ans %= 1000000007;
            }
            Console.WriteLine(ans);
        }
    }
}
