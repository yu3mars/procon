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
            long n = long.Parse(Console.ReadLine());
            long[] x = new long[n];
            long[] y = new long[n];
            long ans = 0;
            for (long i = 0; i < n; i++)
            {
                long[] p = Console.ReadLine().Split().Select(long.Parse).ToArray();
                x[i] = p[0];
                y[i] = p[1];
            }
            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < i; j++)
                {
                    for (long k = 0; k < j; k++)
                    {
                        long a = x[i] - x[k];
                        long b = y[i] - y[k];
                        long c = x[j] - x[k];
                        long d = y[j] - y[k];
                        long s = Math.Abs(a * d - b * c);
                        if (s % 2 == 0 && s != 0)
                        {
                            ans++;
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
