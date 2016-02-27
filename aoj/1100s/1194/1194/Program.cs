using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1194
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] rn = Console.ReadLine().Split(' ');
                int r = int.Parse(rn[0]);
                int n = int.Parse(rn[1]);
                if (r == 0) return;
                int[] hr = new int[41];
                int[] hl = new int[41];
                double ans = double.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    string[] xxh = Console.ReadLine().Split(' ');
                    int xli = int.Parse(xxh[0]) + 20;
                    int xri = int.Parse(xxh[1]) + 20;
                    int hi = int.Parse(xxh[2]);
                    for (int j = xli; j < xri; j++)
                    {
                        hr[j] = Math.Max(hr[j], hi);
                    }
                    for (int j = xli + 1; j <= xri; j++)
                    {
                        hl[j] = Math.Max(hl[j], hi);
                    }
                }
                for (int i = 20 - r; i <= 20 + r; i++)
                {
                    double tmp = r - Math.Sqrt(r * r - Math.Pow(20 - i, 2));
                    if (i == 20 - r)
                    {
                        tmp += hr[i];
                    }
                    else if (i == 20+ r)
                    {
                        tmp += hl[i];
                    }
                    else
                    {
                        tmp += Math.Min(hr[i], hl[i]);
                    }
                    ans = Math.Min(ans, tmp);
                }

                Console.WriteLine(ans);
            }
        }
    }
}
