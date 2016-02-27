using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0114
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int a1 = int.Parse(str[0]);
                int m1 = int.Parse(str[1]);
                int a2 = int.Parse(str[2]);
                int m2 = int.Parse(str[3]);
                int a3 = int.Parse(str[4]);
                int m3 = int.Parse(str[5]);
                if (a1 == 0 && m1 == 0 && a2 == 0 && m2 == 0 && a3 == 0 && m3 == 0)
                {
                    return;
                }
                long ans = Lcm(Loop(a1, m1), Lcm(Loop(a2, m2), Loop(a3, m3)));
                Console.WriteLine(ans);
            }
        }

        static int Loop(int a, int m)
        {
            int x = a;
            int cnt = 1;
            while (x % m != 1)
            {
                x = a * x % m;
                cnt += 1;
            }
            return cnt;
        }

        static long Gcd(long a, long b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }

        static long Lcm(long a, long b)
        {
            return (long)a / Gcd(a, b) * b;
        }
    }
}
