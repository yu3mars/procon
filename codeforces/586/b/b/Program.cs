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
            int[,] a = new int[2, n - 1];
            int[] b = new int[n];
            for (int i = 0; i < 2; i++)
            {
                string[] astr = Console.ReadLine().Split(' ');
                for (int j = 0; j < n - 1; j++)
                {
                    a[i, j] = int.Parse(astr[j]);
                }                
            }
            string[] bstr = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(bstr[i]);
            }
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = b[i];
                for (int j = 0; j < n - 1; j++)
                {
                    if (i > j)
                    {
                        ans[i] += a[0, j];
                    }
                    else
                    {
                        ans[i] += a[1, j];
                    }
                }
            }
            Array.Sort(ans);
            Console.WriteLine(ans[0] + ans[1]);
        }
    }
}
