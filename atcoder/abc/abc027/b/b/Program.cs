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
            string[] astr = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
                sum += a[i];
            }
            if (sum % n != 0)
            {
                Console.WriteLine(-1);
                return;
            }

            int ans = n - 1;
            int cnt = 0;
            int one = sum / n;
            for (int i = 0; i < n - 1; i++)
            {
                cnt += a[i];
                if (cnt == (i + 1) * one)
                {
                    ans--;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
