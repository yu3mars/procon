using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nmstr = Console.ReadLine().Split(' ');
            int n = int.Parse(nmstr[0]);
            int m = int.Parse(nmstr[1]);
            int[] s = new int[m];
            int[] t = new int[m];
            int[] ls = new int[n + 2];
            int[] imos = new int[n + 2];
            for (int i = 0; i < m; i++)
            {
                string[] smstr = Console.ReadLine().Split(' ');
                s[i] = int.Parse(smstr[0]);
                t[i] = int.Parse(smstr[1]);
                ls[s[i]] += 1;
                ls[t[i] + 1] -= 1;
            }
            int tmp = 0;
            for (int i = 0; i < n+2; i++)
            {
                tmp += ls[i];
                imos[i] = tmp;
            }

            int cnt = 0;
            List<int> ans = new List<int>();
            for (int i = 0; i < m; i++)
            {
                bool ok = true;
                for (int j = s[i]; j <= t[i]; j++)
                {
                    if (imos[j] < 2)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok == true)
                {
                    ans.Add(i + 1);
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            foreach (int x in ans)
            {
                Console.WriteLine(x);
            }
        }
    }
}
