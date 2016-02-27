using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long[]> ls = new List<long[]>();
            for (int i = 0; i < n; i++)
            {
                string[] cstr = Console.ReadLine().Split(' ');
                long[] cint = new long[4];
                for (int j = 0; j < 3; j++)
                {
                    cint[j] = long.Parse(cstr[j]);
                }
                cint[3] = i + 1;
                ls.Add(cint);
            }
            int cnt = 0;
            List<long> ans = new List<long>();
            while (ls.Count > 0)
            {
                cnt++;
                ans.Add(ls[0][3]);
                long v = ls[0][0];
                for (int i = 1; i < ls.Count; i++)
                {
                    if (v > 0)
                    {
                        ls[i][2] -= v;
                        v--;
                    }
                    else break;
                }
                for (int i = 1; i < ls.Count; i++)
                {
                    if (ls[i][2] < 0)
                    {
                        for (int j = i + 1; j < ls.Count; j++)
                        {
                            ls[j][2] -= ls[i][1];
                        }
                    }
                }
                ls.Remove(ls[0]);
                for (int i = ls.Count - 1; i >=0; i--)
                {
                    if (ls[i][2] < 0)
                    {
                        ls.Remove(ls[i]);
                    }
                }
            }

            Console.WriteLine(cnt);
            Console.Write(ans[0]);
            for (int i = 1 ; i < ans.Count; i++)
            {
                Console.Write(" {0}", ans[i]);
            }
            Console.WriteLine();
        }
        
    }
}
