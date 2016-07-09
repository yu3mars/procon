using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2331
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] imos = new int[100010];
            for (int i = 0; i < n; i++)
            {
                int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                imos[ab[0] - 1]++;
                imos[ab[1]]--;
            }
            int[] cnt = new int[100010];
            for (int i = 1; i < imos.Length; i++)
            {
                cnt[i] = cnt[i - 1] + imos[i];
            }
            int ans = 0;
            for (int i = 0; i < imos.Length; i++)
            {
                if (i <= cnt[i]) ans = Math.Max(ans, i);
            }
            Console.WriteLine(ans);
        }
    }
}
