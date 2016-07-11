using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            long m = long.Parse(Console.ReadLine());
            long sum = 0;

            long lb = 0;
            long ub = long.MaxValue / 3;

            while(ub-lb>1)
            {
                long mid = (ub + lb) / 2;
                sum = CalcN(mid);
                if (sum >= m)
                {
                    ub = mid;
                }
                else
                {
                    lb = mid;
                }

            }

            if (CalcN(lb) == m) Console.WriteLine(lb);
            else if (CalcN(ub) == m) Console.WriteLine(ub);
            else Console.WriteLine(-1);
        }

        private static long CalcN(long mid)
        {
            long sum = 0;
            for (long k = 2; k * k * k <= mid; k++)
            {
                sum += mid / (k * k * k);
            }

            return sum;
        }
    }
}
