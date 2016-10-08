using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1357
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] y = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] x = new double[n];
            double xmax = 0;
            for (int now = 0; now < n; now++)
            {
                double nowx = y[now];
                for (int bef = 0; bef < now; bef++)
                {
                    nowx = Math.Max(nowx, x[bef] + Math.Sqrt(Math.Pow(y[now] + y[bef], 2) - Math.Pow(y[now] - y[bef], 2)));
                }
                x[now] = nowx;
                xmax = Math.Max(xmax, x[now] + y[now]);
            }
            Console.WriteLine(xmax);
        }
    }
}
