using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            long l = long.Parse(str[0]);
            long r = long.Parse(str[1]);
            for (long i = l+2; i <= r; i++)
            {
                for (long j = l + 1; j < i; j++)
                {
                    for (long k = l; k < i; k++)
                    {
                        if (Gcd(i, j) == 1 && Gcd(j, k) == 1 && Gcd(i, k) != 1)
                        {
                            Console.WriteLine("{0} {1} {2}", k, j, i);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("-1");
        }
        static long Gcd(long a, long b)
        {
            if (a < b)
            {
                long tmp = a;
                a = b;
                b = tmp;
            }
            if (b == 0)
            {
                return a;
            }
            else return (Gcd(b, a % b));
        }
    }
}
