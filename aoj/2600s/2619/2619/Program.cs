using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2619
{
    class Program
    {
        static int[] k;
        static string[] m;
        static List<int>[] ls;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            k = new int[n];
            m = new string[n];
            ls = new List<int>[n]; 
            for (int i = 0; i < n; i++)
            {
                ls[i] = new List<int>();
                k[i] = int.Parse(Console.ReadLine()) - 1;
                m[i] = Console.ReadLine();
                if (i == 0)
                {
                    k[i] = 0;
                }
                else
                {
                    ls[k[i]].Add(i);
                }
            }
            dfs(0, 0);
        }
        static void dfs(int n, int c)
        {
            for (int i = 0; i < c; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine(m[n]);
            for (int i = 0; i < ls[n].Count; i++)
            {
                dfs(ls[n][i], c + 1);
            }
        }
    }
}
