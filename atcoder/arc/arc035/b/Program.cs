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
            long mod = 1000000007;

            int n = int.Parse(Console.ReadLine());
            long[] t = new long[10001];
            for (int i = 0; i < n; i++)
            {
                t[long.Parse(Console.ReadLine())]++;
            }
            long ans = 1;
            long pena = 0;
            long time = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == 0) continue;
                long dans = 1;
                for (int j = 1; j <= t[i]; j++)
                {
                    dans = dans * j % mod;
                    time += i;
                    pena += time;
                }
                ans = (ans * dans) % mod;
            }
            Console.WriteLine(pena);
            Console.WriteLine(ans);
        }
    }
}
