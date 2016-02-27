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
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int[] ls = new int[m + 2];
            int[] score = new int[m + 2];
            int sum = 0;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                string[] lrs = Console.ReadLine().Split(' ');
                int l = int.Parse(lrs[0]);
                int r = int.Parse(lrs[1]);
                int s = int.Parse(lrs[2]);
                ls[l] += s;
                ls[r + 1] -= s;
                sum += s;
            }
            for (int i = 1; i <= m; i++)
            {
                score[i] = score[i - 1] + ls[i];
                min = Math.Min(min, score[i]);
            }

            Console.WriteLine(Math.Max(0, sum - min));
        }
    }
}
