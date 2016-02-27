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
            string[] nm = Console.ReadLine().Split(' ');
            string[] xy = Console.ReadLine().Split(' ');
            string[] astr = Console.ReadLine().Split(' ');
            string[] bstr = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            long x = long.Parse(xy[0]);
            long y = long.Parse(xy[1]);
            long[] a = new long[n];
            long[] b = new long[m];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(astr[i]);
            }
            for (int i = 0; i < m; i++)
            {
                b[i] = long.Parse(bstr[i]);
            }
            int ans = 0;
            long time = 0;
            bool bnow = false;

            int acnt = 0;
            int bcnt = 0;

            while ((bnow == false && acnt < n) || (bnow == true && bcnt < m))
            {
                if (bnow == false)
                {
                    if (time <= a[acnt])
                    {
                        time = a[acnt] + x;
                        bnow = true;
                    }
                    acnt++;
                }
                else
                {
                    if (time <= b[bcnt])
                    {
                        time = b[bcnt] + y;
                        bnow = false;
                        ans++;
                    }
                    bcnt++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
