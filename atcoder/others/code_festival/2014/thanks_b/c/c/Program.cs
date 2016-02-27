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
            string[] vstr = Console.ReadLine().Split(' ');
            string[] fstr = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int[] f = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(vstr[i]);
                f[i] = int.Parse(fstr[i]);
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] < f[i] * 2)
                {
                    ans += 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
