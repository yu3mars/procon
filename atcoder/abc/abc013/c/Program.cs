using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static long a, b, c, d, e, h, n;
        static void Main(string[] args)
        {
            long[] nh = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] abcde = Console.ReadLine().Split().Select(long.Parse).ToArray();
            n = nh[0];
            h = nh[1];
            a = abcde[0];
            b = abcde[1];
            c = abcde[2];
            d = abcde[3];
            e = abcde[4];
            long ans = long.MaxValue / 2;
            for (long x = 0; x <= n; x++)
            {
                long y = CalcY(x);
                if (x + y <= n)
                {
                    ans = Math.Min(ans, a * x + c * y);
                }
            }
            Console.WriteLine(ans);
        }
        static long CalcY(long x)
        {
            long y = (e * (n - x) - h - b * x);
            if (y < 0)
            {
                return 0;
            }
            else return y / (d + e) + 1;
        }
    }
}
