using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static int[] par, rank;

        static void Main(string[] args)
        {
            string[] nq = Console.ReadLine().Split(' ');
            int n = int.Parse(nq[0]);
            int q = int.Parse(nq[1]);
            init(n);
            for (int i = 0; i < q; i++)
            {
                string[] pab = Console.ReadLine().Split(' ');
                int p = int.Parse(pab[0]);
                int a = int.Parse(pab[1]);
                int b = int.Parse(pab[2]);
                if (p == 0)
                {
                    unite(a, b);
                }
                else
                {
                    if (same(a, b)) Console.WriteLine("Yes");
                    else Console.WriteLine("No");
                }
            }
        }

        static void init(int n)
        {
            par = new int[n];
            rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                par[i] = i;
                rank[i] = 0;
            }
        }

        static int root(int x)
        {
            if (par[x] == x)
            {
                return x;
            }
            else
            {
                return par[x] = root(par[x]);
            }
        }

        static bool same(int x, int y)
        {
            return root(x) == root(y);
        }

        static void unite(int x, int y)
        {
            x = root(x);
            y = root(y);
            if (x == y) return;

            if (rank[x] < rank[y])
            {
                par[x] = y;
            }
            else
            {
                par[y] = x;
                if (rank[x] == rank[y]) rank[x]++;
            }
        }
    }
}
