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
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray().Distinct().ToArray().OrderBy(s => s).ToArray(); ;
            int[] ls = new int[a[a.Length - 1] * 2 + 10];
            int cnt = 0;
            ls[0] = 0;
            for (int i = 1; i < ls.Length; i++)
            {
                if(a[cnt]==i)
                {
                    ls[i] = a[cnt];
                    cnt++;
                    if (cnt >= a.Length) cnt = a.Length - 1;
                }
                else
                {
                    ls[i] = ls[i - 1];
                }
            }
            int ans = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1) continue;
                for (int j = a[i] - 1; j < ls.Length; j += a[i])
                {
                    if (ls[j] > a[i])
                    {
                        ans = Math.Max(ans, ls[j] % a[i]);
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
