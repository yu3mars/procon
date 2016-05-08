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
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < a.Length; i++)
            {
                ans += a[i] * nk[1];
            }
            for (int i = 0; i < nk[1]; i++)
            {
                ans -= (a[i] + a[a.Length - i - 1]) * (nk[1] - i - 1);
            }
            Console.WriteLine(ans);
        }
    }
}
