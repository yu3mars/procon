using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1186
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] xs = new int[11175][];
            int[] x = new int[11175];
            int cnt = 0;
            for (int i = 1; i <= 150; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    int[] tmp = { j, i };
                    xs[cnt] = tmp;
                    x[cnt] = (i * i + j * j) * 1000 + j;
                    cnt += 1;
                }
            }
            Array.Sort(x, xs);
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                if (a == 0 && b == 0)
                {
                    return;
                }
                int[] p = { a, b };
                for (int i = 0; i < xs.Length - 1; i++)
                {
                    if (p[0] == xs[i][0] && p[1] == xs[i][1])
                    {
                        Console.WriteLine("{0} {1}", xs[i + 1][0], xs[i + 1][1]);
                        break;
                    }
                }
            }
        }
    }
}
