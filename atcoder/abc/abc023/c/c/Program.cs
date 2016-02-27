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
            string[] rck = Console.ReadLine().Split(' ');
            int r = int.Parse(rck[0]);
            int c = int.Parse(rck[1]);
            int k = int.Parse(rck[2]);
            int n = int.Parse(Console.ReadLine());
            int[] ri = new int[n];
            int[] ci = new int[n];
            int[] rls = new int[r];
            int[] cls = new int[c];
            int[] rcnt = new int[n + 1];
            int[] ccnt = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                string[] rc = Console.ReadLine().Split(' ');
                ri[i] = int.Parse(rc[0]) - 1;
                ci[i] = int.Parse(rc[1]) - 1;
                rls[ri[i]] += 1;
                cls[ci[i]] += 1;
            }
            for (int i = 0; i < r; i++)
            {
                rcnt[rls[i]] += 1;                
            }
            for (int i = 0; i < c; i++)
            {
                ccnt[cls[i]] += 1;                
            }

            long ans = 0;
            for (int i = 0; i <= k; i++)
            {
                ans += rcnt[i] * ccnt[k - i];
            }
            for (int i = 0; i < n; i++)
            {
                int cal = rls[ri[i]] + cls[ci[i]];
                if (cal == k)
                {
                    ans -= 1;
                }
                else if (cal == k + 1)
                {
                    ans += 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
