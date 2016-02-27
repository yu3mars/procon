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
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string[] astr = Console.ReadLine().Split(' ');
            string[] bstr = Console.ReadLine().Split(' ');
            if (n < m)
            {
                Console.WriteLine("NO");
                return;
            }
            int[] a = new int[n];
            int[] b = new int[m];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
            }
            for (int i = 0; i < m; i++)
            {
                b[i] = int.Parse(bstr[i]);
            }
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(a);
            Array.Reverse(b);
            
            for (int i = 0; i < m; i++)
            {
                if (a[i] < b[i])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
