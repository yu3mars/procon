using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSL_2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int q = int.Parse(str[1]);
            int[] ary = new int[n];
            for (int i = 0; i < n; i++)
            {
                ary[i] = 2147483647;
            }
            for (int i = 0; i < q; i++)
            {
                string[] qstr = Console.ReadLine().Split(' ');
                int com = int.Parse(qstr[0]);
                int x = int.Parse(qstr[1]);
                int y = int.Parse(qstr[2]);
                if (com == 0)
                {
                    ary[x] = y;
                }
                else
                {
                    int ans = 2147483647;
                    for (int j = x; j <= y; j++)
                    {
                        ans = Math.Min(ans, ary[j]);
                    }
                    Console.WriteLine(ans);
                }
            }
        }
    }
}
