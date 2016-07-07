using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSL_2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nq =Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nq[0];
            int q = nq[1];
            Segtree tree = new Segtree(n);
            

            for (int i = 0; i < q; i++)
            {
                int[] com = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(com[0]==0)//add
                {
                    tree.add(com[1], com[1], com[2]);
                }
                else//getsum
                {
                    Console.WriteLine(tree.getSum(com[1], com[2])); 
                }
            }
        }
    }
    class Segtree
    {
        int N;
        int[] L;
        int[] R;
        int[] M;
        int[,] np;
        bool[] lazyFlag;

        public Segtree(int _N)
        {
            N = 1;
            while (N < _N) N *= 2;

            L = new int[N * 2];
            R = new int[N * 2];
            M = new int[N * 2];
            np = new int[N * 2, 2];
            lazyFlag = new bool[N * 2];
            L[0] = 0;
            R[0] = N;
            M[0] = N / 2;

            for (int i = 0; i < N - 1; i++)
            {
                np[i, 0] = i * 2 + 1;
                np[i, 1] = i * 2 + 2;
                L[np[i, 0]] = L[i];
                R[np[i, 0]] = L[np[i, 1]] = (L[i] + R[i]) / 2;
                R[np[i, 1]] = R[i];
            }
            for (int i = 0; i < N; i++)
            {
                M[i] = (L[i] + R[i]) / 2;
            }
            init();
        }

        int[] sum;
        int[] lazyadd;
        int[] max;

        void init()
        {
            sum = new int[2 * N];
            lazyadd = new int[2 * N];
            max = new int[2 * N];
        }

        //遅延評価する分を伝播させる
        void lazy(int p)
        {
            if (!lazyFlag[p]) return;
            lazyFlag[p] = false;

            add(L[p], M[p], lazyadd[p], np[p, 0]);
            add(M[p], R[p], lazyadd[p], np[p, 1]);

            lazyadd[p] = 0;
        }

        //親の更新処理
        public void merge(int p)
        {
            max[p] = Math.Max(max[np[p, 0]], max[np[p, 1]]);
            sum[p] = sum[np[p, 0]] + sum[np[p, 1]];
        }

        public int getSum(int l, int r, int p = 0)
        {
            if (l == L[p] && r == R[p])
            {
                //一致時処理
                return sum[p];
            }
            else
            {
                //遅延評価分の伝播
                lazy(p);

                //子の集計
                int ans = 0;
                if (l < M[p]) ans += getSum(l, Math.Min(M[p], r), np[p, 0]);
                if (r > M[p]) ans += getSum(Math.Max(l, M[p]), r, np[p, 1]);
                return ans;
            }
        }

        public int getMax(int l, int r, int p = 0)
        {
            if (l == L[p] && r == R[p])
            {
                //一致時処理
                return max[p];
            }
            else
            {
                //遅延評価分の伝播
                lazy(p);

                //子の集計
                int ans = 0;
                if (l < M[p]) ans = Math.Max(ans, getMax(l, Math.Min(M[p], r), np[p, 0]));
                if (r > M[p]) ans = Math.Max(ans, getMax(Math.Max(l, M[p]), r, np[p, 1]));

                return ans;
            }
        }

        public void add(int l, int r, int v, int p = 0)
        {
            if (l == L[p] && r == R[p])
            {
                //一致時処理
                max[p] += v;
                sum[p] += v;
                lazyadd[p] += v;
                lazyFlag[p] = true;
            }
            else
            {
                //遅延評価分の伝播
                lazy(p);
                //子の更新
                if (l < M[p]) add(l, Math.Min(M[p], r), v, np[p, 0]);
                if (r > M[p]) add(Math.Max(l, M[p]), r, v, np[p, 1]);
                //親の更新
                merge(p);

            }
        }
    }

}
