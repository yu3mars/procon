using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0549
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            int[] d = new int[n - 1];
            int[] go = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            int now = 0;
            for (int i = 0; i < m; i++)
            {
                int today = int.Parse(Console.ReadLine());
                if (today > 0)
                {
                    for (int j = now; j < now + today; j++)
                    {
                        go[j] += 1;
                    }
                }
                else
                {
                    for (int j = now - 1; j > now - 1 + today; j--)
                    {
                        go[j] += 1;
                    }
                }
                now += today;
            }
            long ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                ans = (ans +d[i] * go[i]) % 100000;
            }
            Console.WriteLine(ans);
        }
    }
}
