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
            string[] nmp = Console.ReadLine().Split(' ');
            long n = long.Parse(nmp[0]);
            long m = long.Parse(nmp[1]);
            long p = long.Parse(nmp[2]);
            Console.WriteLine(PowMod(n, p, m));
        }

        static long PowMod(long n,long k,long m)
        {
            if (k == 0)
            {
                return 1;
            }
            else if (k % 2 == 1)
            {
                return PowMod(n, k - 1, m) * n % m;
            }
            else
            {
                long t = PowMod(n, k / 2, m);
                return t * t % m;
            }
        }
    }
}
