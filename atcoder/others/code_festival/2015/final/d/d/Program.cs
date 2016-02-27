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
            int n = int.Parse(Console.ReadLine());
            int[] ls = new int[100001];
            int[] s = new int[n];
            int[] t = new int[n];
            int beg = 0;
            int end = 0;
            
            bool[] change = new bool[100001];
            int ans = 0;
            int now = 0;
            int last = 0;
            bool minus = false;
            for (int i = 0; i < n; i++)
            {
                string[] st = Console.ReadLine().Split(' ');
                s[i] = int.Parse(st[0]);
                t[i] = int.Parse(st[1]);
                ls[s[i]]++;
                ls[t[i]]--;
                change[s[i]] = true;
                change[t[i]] = true;
            }
            for (int i = 0; i < ls.Length; i++)
            {
                if (change[i])
                {
                    now += ls[i];
                    if (ans < now)
                    {
                        ans = now;
                        beg = i;
                        end = i;
                    }
                    else if (ans == now)
                    {
                        end = i;
                    }

                    last = now;
                }
            }
            if (beg != end)
            {
                for (int i = 0; i < n; i++)
                {
                    if (s[i] <= beg && beg < t[i] && s[i] <= end && end < t[i])
                    {
                        ans--;
                        break;
                    }
                }
            }
            else
            {
                ans--;
            }

            if (minus) ans--;
            Console.WriteLine(ans);
        
        }
    }
}
