using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2400
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] tpr = Console.ReadLine().Split(' ');
                int t = int.Parse(tpr[0]);
                int p = int.Parse(tpr[1]);
                int r = int.Parse(tpr[2]);
                if (t == 0 && p == 0 && r == 0)
                {
                    return;
                }
                int[,] wa = new int[t, p];
                int[] ac = new int[t];
                int[] pe = new int[t];
                for (int i = 0; i < r; i++)
                {
                    string[] log = Console.ReadLine().Split(' ');
                    int tid = int.Parse(log[0]) - 1;
                    int pid = int.Parse(log[1]) - 1;
                    int time = int.Parse(log[2]);
                    if (log[3] == "WRONG")
                    {
                        wa[tid, pid] += 1;
                    }
                    else
                    {
                        ac[tid] += 1;
                        pe[tid] += time + wa[tid, pid] * 1200;
                    }
                }
                int[][] ans = new int[t][];
                for (int i = 0; i < t; i++)
                {
                    ans[i] = new int[] { ac[i], pe[i], i + 1 };
                }
                Array.Sort(ans, CompareArray);
                for (int i = 0; i < t; i++)
                {
                    Console.WriteLine("{0} {1} {2}", ans[i][2], ans[i][0], ans[i][1]);
                }
            }
        }

        static int CompareArray(int[] x, int[] y)
        {
            int min = Math.Min(x.Length, y.Length);

            for (int n = 0; n < 1; n++)
            {
                if (x[n] > y[n])
                    return -1;
                else if (x[n] < y[n])
                    return 1;
            }
            for (int n = 1; n < min; n++)
            {
                if (x[n] > y[n])
                    return 1;
                else if (x[n] < y[n])
                    return -1;
            }

            if (x.Length > y.Length)
                return 1;
            else if (x.Length < y.Length)
                return -1;
            else /* if (x.Length == y.Length) */
                return 0;
        }
    }
}
