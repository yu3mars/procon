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
            int[][] com = new int[n][];
            int[][] man = new int[m][];
            int[] a = new int[101];
            int[] b = new int[101];
            int[] c = new int[101];
            for (int i = 0; i < n; i++)
            {
                string[] comstr = Console.ReadLine().Split(' ');
                int[] comtmp = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    comtmp[j] = int.Parse(comstr[j]);
                }
                com[i] = comtmp;
                a[com[i][0]] = Math.Max(a[com[i][0]], com[i][3]);
                b[com[i][1]] = Math.Max(b[com[i][1]], com[i][3]);
                c[com[i][2]] = Math.Max(c[com[i][2]], com[i][3]);
            }
            for (int i = 0; i < 100; i++)
            {
                a[i + 1] = Math.Max(a[i + 1], a[i]);
                b[i + 1] = Math.Max(b[i + 1], b[i]);
                c[i + 1] = Math.Max(c[i + 1], c[i]);
            }

            for (int i = 0; i < m; i++)
            {
                string[] manstr = Console.ReadLine().Split(' ');
                int[] mantmp = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    mantmp[j] = int.Parse(manstr[j]);
                }
                man[i] = mantmp;
            }

            for (int i = 0; i < m; i++)
            {
                int ans = 0;
                ans = Math.Min(a[man[i][0]], Math.Min(b[man[i][1]], c[man[i][2]]));
                Console.WriteLine(ans);
            }
        }
    }
}
