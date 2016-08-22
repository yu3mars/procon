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
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += a[i] / 2;
                a[i] %=2;
                if (i == n - 1) break;
                int tmp = Math.Min(a[i], a[i + 1]);
                ans += tmp;
                a[i] -= tmp;
                a[i + 1] -= tmp;
            }
            Console.WriteLine(ans);
        }
    }
}
