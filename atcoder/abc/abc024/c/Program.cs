using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ndk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int d = ndk[1];
            int k = ndk[2];
            int[] l = new int[d];
            int[] r = new int[d];
            int[] s = new int[k];
            int[] t = new int[k];
            int[] ans = new int[k];

            for (int i = 0; i < d; i++)
            {
                int[] lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                l[i] = lr[0];
                r[i] = lr[1];
            }
            for (int i = 0; i < k; i++)
            {
                int[] st = Console.ReadLine().Split().Select(int.Parse).ToArray();
                s[i] = st[0];
                t[i] = st[1];
                ans[i] = -1;
            }

            for (int lrcnt = 0; lrcnt < d; lrcnt++)
            {
                for (int stcnt = 0; stcnt < k; stcnt++)
                {
                    if (ans[stcnt] >= 0) continue;
                    if (s[stcnt] < l[lrcnt] || r[lrcnt] < s[stcnt]) continue;
                    if(l[lrcnt]<=t[stcnt] && t[stcnt] <= r[lrcnt])
                    {
                        s[stcnt] = t[stcnt];
                        ans[stcnt] = lrcnt + 1;
                    }
                    else if(t[stcnt] < l[lrcnt])
                    {
                        s[stcnt] = l[lrcnt];
                    }
                    else if(r[lrcnt]< t[stcnt])
                    {
                        s[stcnt] = r[lrcnt];
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
