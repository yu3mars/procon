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
            int n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            List<long>[] ls = new List<long>[2];
            for (int i = 0; i < 2; i++)
            {
                ls[i] = new List<long>();
            }
            for (int i = 0; i < n; i++)
            {
                ls[0].Add(a[i]);
                ans += a[i];
            }
            for (int range = 1; range < n; range++)
            {
                int now = range % 2;
                int bef = (now + 1) % 2;
                ls[now] = new List<long>();
                for (int i = 0; i < n - range; i++)
                {
                    long tmp = Math.Min(ls[bef][i], a[i + range]);
                    ans += tmp;
                    ls[now].Add(tmp);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
