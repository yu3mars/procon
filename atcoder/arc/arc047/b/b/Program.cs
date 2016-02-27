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
            int n = int.Parse(Console.ReadLine());
            long[] x = new long[n];
            long[] y = new long[n];
            long[] dx = new long[n];
            long[] dy = new long[n];
            long len = 0;

            for (int i = 0; i < n; i++)
            {
                string[] xy = Console.ReadLine().Split(' ');
                x[i] = long.Parse(xy[0]);
                y[i] = long.Parse(xy[1]);
                dx[i] = x[i] - x[0];
                dy[i] = y[i] - y[0];
                len = Math.Max(len, dx[i] + dy[i]);
            }
            Console.WriteLine(len);

        }
    }
}
