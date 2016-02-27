using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] h = new int[n];
            int[] r = new int[n];
            int[] l = new int[n];
            for (int i = 0; i < n; i++)
            {
                h[i] = int.Parse(Console.ReadLine());
            }
            int tmp = 0;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (tmp < h[i])
                {
                    cnt += 1;
                }
                else
                {
                    cnt = 1;
                }
                l[i] = cnt;
                tmp = h[i];
            }
            tmp = 0;
            cnt = 0;
            for (int i = n-1; i >=0; i--)
            {
                if (tmp < h[i])
                {
                    cnt += 1;
                }
                else
                {
                    cnt = 1;
                }
                r[i] = cnt;
                tmp = h[i];
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, r[i] + l[i]);
            }
            Console.WriteLine(ans - 1);
        }
    }
}
