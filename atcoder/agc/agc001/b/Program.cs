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
            long[] nx = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = nx[0];
            long x = nx[1];

            x = Math.Max(x, n - x);
            long ans = 0;
            long large = x;
            long small = n - x;
            while(small>0)
            {
                ans += large / small * small;
                long tmp = small;
                small = large % small;
                large = tmp;
            }
            Console.WriteLine(ans * 3);
        }


    }
}
