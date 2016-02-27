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
            int[] s = new int[n];
            int[] t = new int[n];
            int[] ls = new int[2 * n + 1];
            for (int i = 0; i < n; i++)
            {
                string[] st = Console.ReadLine().Split(' ');
                s[i] = int.Parse(st[0]);
                t[i] = int.Parse(st[1]);
                ls[s[i]] += 1;
            }
            for (int i = 1; i < ls.Length; i++)
            {
                ls[i] += ls[i - 1];
            }
            for (int i = 0; i < n; i++)
            {
                int ans = ls[t[i]] - ls[s[i]];
                Console.WriteLine(ans);
            }
        }
    }
}
