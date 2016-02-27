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
            string[] nab = Console.ReadLine().Split(' ');
            int na = int.Parse(nab[0]);
            int nb = int.Parse(nab[1]);
            string[] sa = Console.ReadLine().Split(' ');
            string[] sb = Console.ReadLine().Split(' ');
            int[] a = new int[na];
            int[] b = new int[nb];
            for (int i = 0; i < na; i++)
            {
                a[i] = int.Parse(sa[i]);
            }
            for (int i = 0; i < nb; i++)
            {
                b[i] = int.Parse(sb[i]);
            }
            Array.Sort(a);
            Array.Sort(b);
            int ia = 0;
            int ib = 0;
            int iand = 0;
            while (ia < na && ib < nb)
            {
                if (a[ia] == b[ib])
                {
                    iand += 1;
                    ia += 1;
                    ib += 1;
                }
                else if (a[ia] < b[ib])
                {
                    ia += 1;
                }
                else
                {
                    ib += 1;
                }
            }
            int ior = na + nb - iand;
            double ans = (double)iand / ior;
            Console.WriteLine(ans);
        }
    }
}
