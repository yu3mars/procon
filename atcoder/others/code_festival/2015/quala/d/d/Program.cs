using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static long n;
        static long m;
        static long[] x;
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            n = long.Parse(nm[0]);
            m = long.Parse(nm[1]);

            x = new long[m];
            for (int i = 0; i < m; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

            long lb = -1;
            long ub = n * 3 / 2 + 1;

            while (ub - lb > 1)
            {
                long mid = (lb + ub) / 2;
                if (Judge(mid) == true)
                {
                    ub = mid;
                }
                else
                {
                    lb = mid;
                }
            }
            Console.WriteLine(ub);

        }

        static bool Judge(long time)
        {
            long[] dest = new long[m + 1];
            for (int i = 0; i < m; i++)
            {
                dest[i] = Math.Min(dest[i], x[i] - 1);
                long left = x[i] - dest[i] - 1;
                long right = Math.Max(time - left * 2, (time - left) / 2);
                dest[i + 1] = x[i] + right;
                if (left > time || right < 0) return false;
            }
            if (dest[m] >= n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
