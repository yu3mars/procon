using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ak = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = ak[0];
            long k = ak[1];
            long nicho = (long)2e12;
            long now = a;
            long ans = 0;
            if(k==0)
            {
                Console.WriteLine(nicho - a);
                return;
            }
            while(now<nicho)
            {
                now = 1 + (k + 1) * now;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
