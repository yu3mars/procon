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
            /*
            int[] lc = new int[n];
            int[] rc = new int[n];
            int[] qc = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    lc[i] = 0;
                    rc[i] = 0;
                    qc[i] = 0;
                }
                else
                {
                    lc[i] = lc[i - 1];
                    rc[i] = rc[i - 1];
                    qc[i] = qc[i - 1];
                }
                if (s[i] == '(') lc[i]++;
                else if (s[i] == ')') rc[i]++;
                else qc[i]++;
            }
            */
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] lr = Console.ReadLine().Split(' ');
                int l = int.Parse(lr[0]) - 1;
                int r = int.Parse(lr[1]) - 1;
                if ((r - l) % 2 == 0)
                {
                    Console.WriteLine("No");
                    continue;
                }
                int lcnt = 0;
                int rcnt = 0;
                int qcnt = 0;

                bool ng = false;
                for (int j = l; j <= r; j++)
                {
                    if (s[j] == '(') lcnt++;
                    else if (s[j] == ')') rcnt++;
                    else qcnt++;
                    if (lcnt + qcnt < rcnt)
                    {
                        ng = true;
                        break;
                    }
                }
                if (ng) Console.WriteLine("No");
                else Console.WriteLine("Yes");
            }
        }
    }
}
