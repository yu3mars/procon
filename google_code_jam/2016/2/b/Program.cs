using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-sample.txt"))
            {
                using (StreamReader r = new StreamReader(@"B-sample.in"))
                {
                    int t = int.Parse(r.ReadLine());
                    for (int i = 0; i < t; i++)
                    {
                        int[] nk = r.ReadLine().Split().Select(int.Parse).ToArray();
                        int n = nk[0];
                        int k = nk[1];
                        double[] p = r.ReadLine().Split().Select(double.Parse).ToArray().OrderBy(s => s).ToArray(); ;
                        double[] ls = new double[k];
                        for (int j = 0; j < k/2; j++)
                        {
                            ls[j] = p[j];
                            ls[k - 1 - j] = p[n - 1 - j];
                        }
                        double ans = 0;
                        for (int j = 0; j < (int)Math.Pow(2,k)+1; j++)
                        {
                            if (bitCount(j) % 2 == 1) continue;
                            double tmp = 1;
                            for (int x = 0; x < k; x++)
                            {
                                if ((j >> x) % 2 == 0)
                                {
                                    tmp *= ls[x];
                                }
                                else tmp *= (1 - ls[x]);
                            }
                            ans += tmp;
                        }

                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }

        static int bitCount(long x)
        {
            x = (x & 0x5555555555555555) + (x >> 1 & 0x5555555555555555);
            x = (x & 0x3333333333333333) + (x >> 2 & 0x3333333333333333);
            x = (x & 0x0f0f0f0f0f0f0f0f) + (x >> 4 & 0x0f0f0f0f0f0f0f0f);
            x = (x & 0x00ff00ff00ff00ff) + (x >> 8 & 0x00ff00ff00ff00ff);
            x = (x & 0x0000ffff0000ffff) + (x >> 16 & 0x0000ffff0000ffff);
            return (int)((x & 0x00000000ffffffff) + (x >> 32 & 0x00000000ffffffff));
        }


    }
}
