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
            int n = int.Parse(Console.ReadLine());
            int[] h = new int[n];
            int[] s = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] hs = Console.ReadLine().Split(' ');
                h[i] = int.Parse(hs[0]);
                s[i] = int.Parse(hs[1]);
            }
            long left = 0;
            long right = (long)1e18;
            while (right - left > 1)
            {
                long mid = (left + right) / 2;
                if (check(h, s, mid) == true) right = mid;
                else left = mid;
            }
            Console.WriteLine(right);
        }

        static bool check(int[] h, int[] s, long mid)
        {
            int n = h.Length;
            int[] lssec = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (h[i] > mid) return false;
                int sec = (int)Math.Min(n, (mid - h[i]) / s[i]);
                if (sec > n) return false;
                lssec[sec] += 1;
            }
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                cnt += lssec[i];
                if (cnt > i + 1) return false;
            }
            return true;
        }
    }
}
