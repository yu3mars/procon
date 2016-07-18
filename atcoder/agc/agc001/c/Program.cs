using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static int inf = int.MaxValue / 2;

        static List<Edge[]> G;
        static int n;
        static int[] d;

        static bool[] vis;
        static int cnt;

        static void bfs(int s)
        {
            for (int i = 0; i < n; i++)
            {
                d[i] = inf;
            }
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(s);
            d[s] = 0;
            int u;
            while (Q.Count>0)
            {
                u = Q.Dequeue();
                for (int i = 0; i < G[u].Length; i++)
                {
                    Edge e = G[u][i];
                    if(d[e.t]==inf)
                    {
                        d[e.t] = d[u] + e.w;
                        Q.Enqueue(e.t);
                    }
                }
            }
        }

        static void solve()
        {
            bfs(0);
            int maxv = 0;
            int tgt = 0;
            for (int i = 0; i < n; i++)
            {
                if (d[i] == inf) continue;
                if(maxv<d[i])
                {
                    maxv = d[i];
                    tgt = i;
                }
            }

            bfs(tgt);
            maxv = 0;
            for (int i = 0; i < n; i++)
            {
                if (d[i] == inf) continue;
                maxv = Math.Max(maxv, d[i]);
            }

        }

        static void Main(string[] args)
        {
        }
    }

    class Edge
    {
        public int t, w;
        Edge() { }
        Edge(int _t, int _w)
        {
            t = _t;
            w = _w;
        }
    }


}
