using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static string s;
        static int[] ls;
        static List<int> q;
        static int n;
        static int k;
        static int ans;

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            n = int.Parse(nk[0]);
            k = int.Parse(nk[1]);
            s = Console.ReadLine();
            ls = new int[n];
            q = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '0')
                {
                    ls[i] = -1;
                }
                else if (s[i] == '1')
                {
                    ls[i] = 1;
                }
                else
                {
                    ls[i] = 0;
                    q.Add(i);
                }
            }

        }

        static void ChangeQ(int place, int val)
        {
            ls[q[place]] = val;
            if (place < q.Count)
            {
                ChangeQ(place + 1, val);
                ChangeQ(place + 1, -val);
            }
            else
            {
                bool ng = false;
                int tmp = 0;
                for (int i = 0; i < n; i++)
                {
                    tmp += ls[i];
                    if (Math.Abs(tmp) > k)
                    {
                        ng = true;
                        break;
                    }
                }
                if (ng == false)
                {
                    ans = (ans + 1) % 1000000007;
                }
            }
        }
    }
}
