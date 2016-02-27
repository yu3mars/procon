using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nma = Console.ReadLine().Split(' ');
                int n = int.Parse(nma[0]);
                int m = int.Parse(nma[1]);
                int a = int.Parse(nma[2]);
                if (n == 0 && m == 0 && a == 0)
                {
                    return;
                }
                int[,] map = new int[1001, n + 1];
                for (int i = 0; i < m; i++)
                {
                    string[] hpq = Console.ReadLine().Split(' ');
                    int h = int.Parse(hpq[0]);
                    int p = int.Parse(hpq[1]);
                    int q = int.Parse(hpq[2]);
                    map[h, p] = q;
                    map[h, q] = p;
                }
                for (int i = 1000; i > 0; i--)
                {
                    int next = map[i, a];
                    if (next != 0)
                    {
                        a = next;
                    }
                }
                Console.WriteLine(a);
            }
        }
    }
}
