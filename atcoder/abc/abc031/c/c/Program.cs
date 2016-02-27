using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] astr = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
            }
            int ans = -1000000;
            for (int i = 0; i < n; i++)
            {
                int aoki = -1000000;
                int tkhs = -1000000;
                for (int j = 0; j < n; j++)
                {
                    int tmpaoki = 0;
                    int tmptaka = 0;
                    if (j < i)
                    {
                        for (int k = j; k <= i; k += 2)
                        {
                            tmptaka += a[k];
                        }
                        for (int k = j + 1; k <= i; k += 2)
                        {
                            tmpaoki += a[k];
                        }
                    }
                    else if (i < j)
                    {
                        for (int k = i; k <= j; k += 2)
                        {
                            tmptaka += a[k];
                        }
                        for (int k = i + 1; k <= j; k += 2)
                        {
                            tmpaoki += a[k];
                        }
                    }
                    else continue;
                    if (tmpaoki > aoki)
                    {
                        aoki = tmpaoki;
                        tkhs = tmptaka;
                    }
                }
                ans = Math.Max(ans, tkhs);
            }
            Console.WriteLine(ans);
        }
    }
}
