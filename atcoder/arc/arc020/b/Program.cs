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
            int[] nc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nc[0];
            int c = nc[1];
            int[] a = new int[n];
            int[] x = new int[10];
            int[] y = new int[10];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine()) - 1;
                if (i % 2 == 0) x[a[i]]++;
                else y[a[i]]++;
            }
            List<int> xmax = new List<int>();
            List<int> ymax = new List<int>();
            xmax.Add(0);
            ymax.Add(0);
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > x[xmax[0]])
                {
                    xmax = new List<int>();
                    xmax.Add(i);
                }
                else if (x[i] == x[xmax[0]])
                {
                    xmax.Add(i);
                }

                if (y[i] > y[ymax[0]])
                {
                    ymax = new List<int>();
                    ymax.Add(i);
                }
                else if (y[i] == y[ymax[0]])
                {
                    ymax.Add(i);
                }
            }

            int ans = 0;
            if (xmax.Count == 1 && ymax.Count == 1 && xmax[0] == ymax[0])
            {
                Array.Sort(x);
                Array.Reverse(x);
                Array.Sort(y);
                Array.Reverse(y);
                ans = n - Math.Max(x[0] + y[1], x[1] + y[0]);
            }
            else
            {
                ans = n - x[xmax[0]] - y[ymax[0]];
            }
            Console.WriteLine(ans * c);
        }
    }
}
