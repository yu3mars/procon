using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"A-large.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] str = r.ReadLine().Split(' ');
                        int max = int.Parse(str[0]);
                        int[] ls = new int[max + 1];
                        for (int j = 0; j <= max; j++)
                        {
                            ls[j] = int.Parse(str[1][j].ToString());
                        }
                        int cnt = 0;
                        int ans = 0;
                        for (int j = 0; j <= max; j++)
                        {
                            if (cnt - j < 0 && ls[j] > 0)
                            {
                                ans += j - cnt;
                                cnt = j;
                            }
                            cnt += ls[j];
                        }
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
