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
            string[] nt = Console.ReadLine().Split(' ');
            int n = int.Parse(nt[0]);
            int t = int.Parse(nt[1]);
            int[] a = new int[n];
            int[] b = new int[n];
            int[] d = new int[n];
            int sum = 0;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                a[i] = int.Parse(ab[0]);
                b[i] = int.Parse(ab[1]);
                d[i] = a[i] - b[i];
                sum += a[i];
            }
            Array.Sort(d);
            Array.Reverse(d);
            for (int i = 0; i < n; i++)
            {
                if (sum <= t)
                {
                    Console.WriteLine(cnt);
                    return;
                }
                else
                {
                    sum -= d[i];
                    cnt += 1;
                }
            }
            if (sum <= t)
            {
                Console.WriteLine(cnt);
                return;
            }
            else
            {
                Console.WriteLine(-1);
                return;
            }

        }
    }
}
