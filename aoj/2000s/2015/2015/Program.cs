using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                if (n == 0 && m == 0) return;
                int[] h = new int[n];
                int[] w = new int[m];
                for (int i = 0; i < n; i++)
                {
                    h[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < m; i++)
                {
                    w[i] = int.Parse(Console.ReadLine());
                }
                SortedDictionary<int, int> hdic = new SortedDictionary<int, int>();
                int ans = 0;
                int sum = 0;

                for (int i = 0; i < n; i++)
                {
                    sum = 0;
                    for (int j = i; j < n; j++)
                    {
                        sum += h[j];
                        if (hdic.ContainsKey(sum))
                        {
                            hdic[sum] += 1;
                        }
                        else
                        {
                            hdic.Add(sum, 1);
                        }
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    sum = 0;
                    for (int j = i; j < m; j++)
                    {
                        sum += w[j];
                        if (hdic.ContainsKey(sum))
                        {
                            ans += hdic[sum];
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
