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
            string[] str = Console.ReadLine().Split(' ');
            int m = int.Parse(str[0]);
            int n = int.Parse(str[1]);
            double sum = 0;
            double[] powls = new double[m + 1];
            powls[0] = 0.0;
            for (int i = 1; i <= m; i++)
            {
                powls[i] = Math.Pow((double)i / (double)m, n);
            }

            for (int i = m; i > 0; i--)
            {
                sum += (double)i * (powls[i] - powls[i - 1]);
            }
            string sumstr = sum.ToString("F12");
            sumstr = sumstr.Replace(',', '.');
            Console.WriteLine(sumstr);
        }
    }
}
