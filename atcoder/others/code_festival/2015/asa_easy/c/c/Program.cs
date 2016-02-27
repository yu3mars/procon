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
            string[] nkmr = Console.ReadLine().Split(' ');
            long n = long.Parse(nkmr[0]);
            long k = long.Parse(nkmr[1]);
            long m = long.Parse(nkmr[2]);
            long r = long.Parse(nkmr[3]);
            long[] s = new long[n - 1];

            for (int i = 0; i < n - 1; i++)
            {
                s[i] = long.Parse(Console.ReadLine());
            }
            Array.Sort(s);
            Array.Reverse(s);

            long sum = 0;
            long ans = -1;
            for (int i = 0; i < k - 1; i++)
            {
                sum += s[i];
            }
            if (n == k)
            {
                if (sum + m >= r * k)
                {
                    ans = Math.Max(0, r * k - sum);
                }
            }
            else if (sum + s[k-1] >= r * k)
            {
                ans = 0;
            }
            else if (sum + m >= r * k)
            {
                ans = r * k - sum;
            }



            Console.WriteLine(ans);
        }
    }
}
