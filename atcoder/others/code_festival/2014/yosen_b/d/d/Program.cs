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
            int[] h = new int[n + 2];
            int[] l = new int[n + 2];
            int[] r = new int[n + 2];
            h[0] = int.MaxValue;
            h[n + 1] = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                h[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n; i > 0; i--)
            {
                r[i] = i + 1;
                while (h[i] >= h[r[i]])
                {
                    r[i] = r[r[i]];
                }
            }
            for (int i = 1; i <= n; i++)
            {
                l[i] = i - 1;
                while (h[i] >= h[l[i]])
                {
                    l[i] = l[l[i]];
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(r[i] - l[i] - 2);
            }
        }
    }
}

