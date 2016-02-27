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
            int[] score = new int[n];
            int[] cntknow = new int[n];
            int[] sumknow = new int[n];
            bool[,] know = new bool[n, n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
                know[i, i] = true;
                cntknow[i] = 1;
                sum += score[i];
                sumknow[i] = score[i];
            }
            int m = int.Parse(Console.ReadLine());
            for (int queri = 0; queri < m; queri++)
            {
                string[] q = Console.ReadLine().Split(' ');
                int a = int.Parse(q[0]);
                int b = int.Parse(q[1]) - 1;
                int c = int.Parse(q[2]) - 1;
                if (a == 0)
                {
                    if (know[b, c] == false)
                    {
                        know[b, c] = true;
                        cntknow[b]++;
                        sumknow[b] += score[c];
                    }
                }
                else
                {
                    if (know[b, c] == true)
                    {
                        Console.WriteLine("{0} {0}", score[c]);
                    }
                    else
                    {
                        int min = Math.Max(0, sum - sumknow[b] - 100 * (n - cntknow[b] - 1));
                        int max = Math.Min(100, sum - sumknow[b]);
                        Console.WriteLine("{0} {1}", min, max);
                    }
                }
            }
        }
    }
}
