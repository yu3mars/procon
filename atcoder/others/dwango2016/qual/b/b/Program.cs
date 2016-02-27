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
            string[] kstr = Console.ReadLine().Split(' ');
            int[] k = new int[n - 1];
            int[] ans = new int[n];
            for (int i = 0; i < n-1; i++)
            {
                k[i] = int.Parse(kstr[i]);
            }
            ans[0] = k[0];
            ans[n - 1] = k[n - 2];            
            for (int i = 1; i < n - 1; i++)
            {
                ans[i] = Math.Min(k[i - 1], k[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(ans[i]);
            }
            Console.WriteLine();
        }
    }
}
