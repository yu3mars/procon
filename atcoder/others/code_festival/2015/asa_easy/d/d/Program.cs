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
            string s = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                string str1 = s.Substring(0, i);
                string str2 = s.Substring(i);
                ans = Math.Max(ans, lcs(str1, str2));

            }
            Console.WriteLine(n - ans * 2);
        }

        static int lcs(string x, string y)
        {
            int num = 101;
            int[,] c = new int[num, num];
            int m = x.Length;
            int n = y.Length;
            int maxl = 0;
            x = ' ' + x;
            y = ' ' + y;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (x[i] == y[j])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        c[i, j] = Math.Max(c[i - 1, j], c[i, j - 1]);
                    }
                    maxl = Math.Max(maxl, c[i, j]);
                }
            }
            return maxl;
        }
    }
}
