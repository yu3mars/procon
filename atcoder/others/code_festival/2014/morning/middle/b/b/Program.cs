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
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] phuman = new int[100002];
            int[] mhuman = new int[100002];
            for (int i = 0; i < n; i++)
            {
                string[] bstr = Console.ReadLine().Split(' ');
                int[] str = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    str[j] = int.Parse(bstr[j]);
                }
                phuman[str[0]] += 1;
                mhuman[str[1]] -= 1;
            }

            int[] makura = new int[100002];
            for (int i = 0; i < m; i++)
            {
                int h = int.Parse(Console.ReadLine());
                makura[h] += 1;
            }

            int ans = 0;
            int need = 0;
            for (int i = 0; i <= n; i++)
            {
                need += phuman[i];
               
                if (need > 0 && makura[i] > 0)
                {
                    int ac = Math.Min(need, makura[i]);
                    need -= ac;
                    ans += ac;
                }
                need += mhuman[i];
                if (need < 0)
                {
                    need = 0;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
