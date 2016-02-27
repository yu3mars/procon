using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0594
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[2]);
            int[][] target = new int[n][];
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                int[] str3 = new int[2];
                str3[0] = int.Parse(str2[0]);
                str3[1] = int.Parse(str2[1]);
                target[i] = str3;
            }
            for (int i = 0; i < n-1; i++)
            {
                int x = target[i][0] - target[i + 1][0];
                int y = target[i][1] - target[i + 1][1];

                if (x * y > 0)
                {
                    cnt += Math.Max(Math.Abs(x), Math.Abs(y));
                }
                else
                {
                    cnt += Math.Abs(x) + Math.Abs(y);
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
