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
                using (StreamReader r = new StreamReader(@"C-Sample.in"))
                {
                    int t = int.Parse(r.ReadLine());
                    for (int i = 0; i < t; i++)
                    {
                        int n = int.Parse(r.ReadLine());
                        int ans = 0;
                        int[] ls = r.ReadLine().Split().Select(int.Parse).ToArray();
                        for (int j = 0; j < ls.Length; j++)
                        {
                            ls[j]--;
                        }
                        int[] bgn = new int[n];
                        int[] end = new int[n];
                        int[] cnt = new int[n];
                        bool[] loop = new bool[n]; // wa ni natteru
                        bool[] valid = new bool[n]; // tandoku de seiritsu
                        for (int j = 0; j < n; j++)
                        {
                            SortedSet<int> set = new SortedSet<int>();
                            int now = j;
                            int before = j;
                            bool isloop = loop[j];
                            while(set.Contains(now)==false)
                            {
                                set.Add(now);
                                before = now;
                                now = ls[now];
                                if(loop[now])
                                {
                                    isloop = true;
                                    break;
                                }
                            }
                            if (isloop) continue;

                            if (now == j)//loop
                            {
                                cnt[j] = set.Count;
                                loop[j] = true;
                                valid[j] = true;
                                foreach (var num in set)
                                {
                                    loop[num] = true;
                                }
                            }
                            else if (ls[before] == now)//tandoku ok
                            {
                                foreach (var num in set)
                                {
                                    if(cnt[num]<set.Count)
                                    {
                                        cnt[num] = set.Count;
                                        bgn[num] = j;
                                        end[num] = before;
                                        valid[num] = true;
                                    }
                                }
                            }
                            else
                            {
                                cnt[j] = set.Count;
                                end[j] = now;
                            }
                        }
                        ans = cnt.Max();
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                        w.WriteLine(string.Join(" ", cnt));//debug
                        w.WriteLine(string.Join(" ", end));//debug
                    }
                }
            }
        }
    }
}
