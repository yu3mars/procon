using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTL_1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            long m = long.Parse(str[0]);
            int n = int.Parse(str[1]);
            Console.WriteLine(pos(m, n));
        }
        static long pos(long m, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            long ans = pos(m * m % 1000000007, n / 2);
            if (n % 2 == 1)
            {
                ans = ans * m % 1000000007;
            }
            return ans;
        }
    }
}
