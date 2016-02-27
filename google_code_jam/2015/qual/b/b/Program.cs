using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"B-large.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        int d = int.Parse(r.ReadLine());
                        string[] pstr = r.ReadLine().Split(' ');
                        int[] p = new int[1001];
                        int[] pimo = new int[1001];
                        int max = int.MinValue;
                        for (int j = 0; j < d; j++)
                        {
                            int nld = int.Parse(pstr[j]);
                            p[nld] += 1;
                            max = Math.Max(max, nld);
                        }
                        int imotmp = 0;
                        for (int j = 1000; j > 0; j--)
                        {
                            imotmp += p[j];
                            pimo[j] = imotmp;
                        }
                        int ans = max;
                        for (int j = max; j > 1; j--)
                        {
                            int tmp = j;
                            for (int k = j + 1; k < 1001; k += j)
                            {
                                tmp += pimo[k];
                            }
                            ans = Math.Min(ans, tmp);
                        }                    
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
