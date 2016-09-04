using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static long n;
        static void Main(string[] args)
        {
            long[] nx = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            n = nx[0];
            long x = nx[1];
            long[,] data = new long[n, n];
            long ans = 0;

            for (long i = 0; i < n; i++)
            {
                data[0, i] = a[i];
                ans += a[i];
            }
            for (long magic = 1; magic < n; magic++)
            {
                long tmp = magic * x;
                for (long slime = 0; slime < n; slime++)
                {
                    data[magic, slime] =
                        Math.Min(data[magic - 1, slime], 
                        data[0, fixNum(slime - magic)]);
                    tmp += data[magic, slime];
                }
                ans = Math.Min(ans, tmp);
            }
            Console.WriteLine(ans);
        }

        static long fixNum(long i)
        {
            if (i < 0) return i + n;
            return i;
        }
    }
}
