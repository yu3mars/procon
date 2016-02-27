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
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string[] astr = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            int[] ls = new int[m + 1];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
                ls[a[i]]++;
            }
            for (int i = 0; i <= m; i++)
            {
                if (ls[i] > n / 2)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("?");
        }
    }
}
