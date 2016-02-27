using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2300
{
    class Program
    {
        static int n, m, cnt;
        static double ans, sum;
        static double[] a, b, c;
        static double[,] diff;
        static List<int> ls;
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            n = int.Parse(nm[0]);
            m = int.Parse(nm[1]);
            ans = 0.0;
            sum = 0.0;
            a = new double[n];
            b = new double[n];
            c = new double[n];
            diff = new double[n, n];
            ls = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string[] abc = Console.ReadLine().Split(' ');
                a[i] = double.Parse(abc[0]);
                b[i] = double.Parse(abc[1]);
                c[i] = double.Parse(abc[2]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    diff[i, j] = GetDiff(i, j);
                }
            }
            Loop(0);
            Console.WriteLine(ans);
        }

        static double GetDiff(int p, int q)
        {
            return Math.Pow((a[p] - a[q]), 2) 
                + Math.Pow((b[p] - b[q]), 2) + Math.Pow((c[p] - c[q]), 2);
        }

        static void Loop(int before)
        {
            if (m == cnt)
            {
                ans = Math.Max(ans,sum);
            }
            else
            {
                for (int i = before; i < n; i++)
                {
                    cnt += 1;
                    double tmp = 0;
                    foreach (int x in ls)
                    {
                        tmp += diff[x, i];
                    }
                    sum += tmp;
                    ls.Add(i);
                    Loop(i + 1);
                    cnt -= 1;
                    sum -= tmp;
                    ls.Remove(i);
                }
            }
        }
    }

}
