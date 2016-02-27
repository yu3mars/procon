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
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int t = int.Parse(str[1]);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int ans = 0;
            for (int i = 1; i <= t; i++)
            {
                int tmp = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i % a[j] == 0)
                    {
                        tmp += 1;
                    }
                }
                ans = Math.Max(ans, tmp);
            }
            Console.WriteLine(ans);
        }
    }
}
