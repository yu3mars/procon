using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2386
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] c = new int[n][];
            for (int i = 0; i < n; i++)
            {
                c[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ans += Math.Min(c[i][j], c[j][i]);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
