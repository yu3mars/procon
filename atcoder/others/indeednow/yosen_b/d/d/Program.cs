using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nc = Console.ReadLine().Split(' ');
            string[] astr = Console.ReadLine().Split(' ');
            int n = int.Parse(nc[0]);
            int c = int.Parse(nc[1]);
            if (n > 20) return;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
            }
            for (int i = 1; i <= c; i++)
            {
                int ans = n * (n + 1) / 2;
                int now = -1;
                int len = 0;
                for (int j = 0; j < n; j++)
                {
                    if (a[j] == i)
                    {
                        len = j - now - 1;
                        ans -= len * (len + 1) / 2;
                        now = j;
                    }
                }
                len = n - now - 1;
                ans -= len * (len + 1) / 2;
                Console.WriteLine(ans);
            }

        }
    }
}
