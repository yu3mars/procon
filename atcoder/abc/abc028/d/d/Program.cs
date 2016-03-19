using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            long n = int.Parse(nk[0]);
            long k = int.Parse(nk[1]);
            double ans = (double)((k - 1) * (n - k) * 6 + (n - 1) * 3 + 1) / (n * n * n);
            Console.WriteLine(ans);
        }
    }
}
