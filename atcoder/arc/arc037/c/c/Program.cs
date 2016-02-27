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
            string[] nk = Console.ReadLine().Split(' ');
            ulong n = ulong.Parse(nk[0]);
            ulong k = ulong.Parse(nk[1]);
            string[] astr = Console.ReadLine().Split(' ');
            string[] bstr = Console.ReadLine().Split(' ');
            ulong[] a = new ulong[n];
            ulong[] b = new ulong[n];
            for (ulong i = 0; i < n; i++)
            {
                a[i] = ulong.Parse(astr[i]);
                b[i] = ulong.Parse(bstr[i]);
            }

            ulong[] ls = new ulong[n * n];
            for (ulong i = 0; i < n; i++)
            {
                for (ulong j = 0; j < n; j++)
                {
                    ls[i * n + j] = a[i] * b[j];
                }
            }
            Array.Sort(ls);
            Console.WriteLine(ls[k - 1]);
        }
    }
}
