using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            long n = long.Parse(nk[0]);
            long k = long.Parse(nk[1]);
            long[] s = new long[n];
            int ans = 0;
            int bgn = 0;
            int end = 0;
            int anstmp = 0;
            long cnt = 1;
            for (int i = 0; i < n; i++)
            {
                s[i] = long.Parse(Console.ReadLine());
                if (s[i] == 0)
                {
                    Console.WriteLine(n);
                    return;
                }
            }
            while (bgn < n)
            {
                cnt *= s[bgn];
                anstmp++;
                if (cnt <= k)
                {
                    ans = Math.Max(ans, anstmp);
                }
                else
                {
                    while (end < bgn)
                    {
                        cnt /= s[end];
                        anstmp--;
                        end++;
                        if (cnt < k)
                        {
                            ans = Math.Max(ans, anstmp);
                            break;
                        }
                    }
                }
                bgn++;
            }
            Console.WriteLine(ans);
        }
    }
}
